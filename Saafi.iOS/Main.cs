﻿using System;
using UIKit;

namespace Saafi.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            try
            {
                UIApplication.Main(args, null, "AppDelegate");

            }
            catch (Exception ex)
            {
                string e = ex.Message;
                throw ex;
            }
        }
    }
}