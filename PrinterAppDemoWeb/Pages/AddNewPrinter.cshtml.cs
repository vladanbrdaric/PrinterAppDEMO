using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PrinterAppDemoWebLibrary.Models;
using PrinterAppDemoWebLibrary.Services;

namespace PrinterAppDemoWeb.Pages
{
    public class AddNewPrinterModel : PageModel
    {
        private readonly ILogger<AddNewPrinterModel> _logger;
        private readonly IQueueServiceSender _queue;



        // Values from the form 'AddNewPrinter' page will be stored in this object and sent to the API 
        public PrinterBasicModel Printer { get; set; } = new PrinterBasicModel();
        string queueName = "printerqueue";

        [BindProperty]
        [Required]
        public string IpAddress { get; set; }

        [BindProperty]
        [Required]
        public string Description { get; set; }

        [BindProperty]
        [Required]
        public string Location { get; set; }


        // Constructor
        public AddNewPrinterModel(ILogger<AddNewPrinterModel> logger, IHttpClientFactory httpClientFactory, IQueueServiceSender queue)
        {
            _logger = logger;
            _queue = queue;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            // check if IP address is valid.
            bool isValidIp = IsValidIP(IpAddress);

            if (ModelState.IsValid && isValidIp == true)
            {
                Printer.IpAddress = IpAddress;
                Printer.Description = Description;
                Printer.Location = Location;

                // Send created printer to Azure queue service.
                await PublishMessage();

                return new RedirectToPageResult("ChooseWhereToGo"); 
            }
            else
            {
                ModelState.Clear();
                return Page();
            }
        }

        private async Task PublishMessage()
        {
            await _queue.SendMessageAsync(Printer, queueName);
        }

        // Validation method
        private bool IsValidIP(string ipAddress)
        {
            //Match pattern for IP address 
            string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            bool output = false;

            //Regular Expression object    
            Regex check = new Regex(pattern);

            //check to make sure an ip address was provided    
            if (string.IsNullOrEmpty(ipAddress))
            {
                //returns false if IP is not provided
                output = false;
            }
            else
            {
                //Matching the pattern    
                output = check.IsMatch(ipAddress, 0);
            }

            return output;
        }


        // Reset entered values
        private void ResetInputValues()
        {
            IpAddress = "";
            Location = "";
            Description = "";
        }
    }
}
