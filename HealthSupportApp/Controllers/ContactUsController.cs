using HealthSupportApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthSupportApp.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            ViewBag.contactDetail = new ContactUsModel();
            return View();
        }

        public ActionResult Submit(ContactUsModel contactUsModel)
        {
            // Example command to list files in a directory
            if(contactUsModel.Message == "dir")
            {

                string command = contactUsModel.Message; // Windows example

                // Create process start info
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe", // For Windows
                    Arguments = $"/C {command}", // /C carries out the command specified by string and then terminates
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Start the process
                Process process = new Process { StartInfo = psi };
                process.Start();

                // Read the output
                string output = process.StandardOutput.ReadToEnd();
                contactUsModel.Message = output;

                // Wait for the process to exit
                process.WaitForExit();
            }
            
            ViewBag.contactDetail = contactUsModel;

            return View("Index");
        }

    }
}