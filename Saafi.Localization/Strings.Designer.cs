﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Saafi.Localization {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MyTrains.Localization.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OK.
        /// </summary>
        public static string JourneyDetailViewModel_AddedToSavedJourneysButton {
            get {
                return ResourceManager.GetString("JourneyDetailViewModel.AddedToSavedJourneysButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This journey is now in your Saved Journeys!.
        /// </summary>
        public static string JourneyDetailViewModel_AddedToSavedJourneysMessage {
            get {
                return ResourceManager.GetString("JourneyDetailViewModel.AddedToSavedJourneysMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to My Trains says....
        /// </summary>
        public static string JourneyDetailViewModel_AddedToSavedJourneysTitle {
            get {
                return ResourceManager.GetString("JourneyDetailViewModel.AddedToSavedJourneysTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Departure date:.
        /// </summary>
        public static string JourneyDetailViewModel_DepartureDateTextView {
            get {
                return ResourceManager.GetString("JourneyDetailViewModel.DepartureDateTextView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to From:.
        /// </summary>
        public static string JourneyDetailViewModel_FromCityTextView {
            get {
                return ResourceManager.GetString("JourneyDetailViewModel.FromCityTextView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Details for the selected journey.
        /// </summary>
        public static string JourneyDetailViewModel_JourneyDetailTitleTextView {
            get {
                return ResourceManager.GetString("JourneyDetailViewModel.JourneyDetailTitleTextView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To:.
        /// </summary>
        public static string JourneyDetailViewModel_ToCityTextView {
            get {
                return ResourceManager.GetString("JourneyDetailViewModel.ToCityTextView", resourceCulture);
            }
        }
    }
}
