﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Round.Cli.Localizations {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Round.Cli.localizations.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Round a number to a specified number of decimal places..
        /// </summary>
        internal static string Command_Round_Decimal_Description {
            get {
                return ResourceManager.GetString("Command.Round.Decimal.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Round a number to a specified number of Significant Figures..
        /// </summary>
        internal static string Command_Round_SignificantFigure_Description {
            get {
                return ResourceManager.GetString("Command.Round.SignificantFigure.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No number to be rounded was provided..
        /// </summary>
        internal static string Error_Number_NoInput {
            get {
                return ResourceManager.GetString("Error.Number.NoInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value you provided was.
        /// </summary>
        internal static string Input_ProvidedValue {
            get {
                return ResourceManager.GetString("Input.ProvidedValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value rounded to the precision you specified.
        /// </summary>
        internal static string Input_RoundedValue {
            get {
                return ResourceManager.GetString("Input.RoundedValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of Decimal Places you wanted was.
        /// </summary>
        internal static string Input_Rounding_DecimalPlaces {
            get {
                return ResourceManager.GetString("Input.Rounding.DecimalPlaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You didn&apos;t provide the number of Decimal Places you wanted, so we defaulted to.
        /// </summary>
        internal static string Input_Rounding_DecimalPlaces_NotProvided {
            get {
                return ResourceManager.GetString("Input.Rounding.DecimalPlaces.NotProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of Significant Figures you wanted was.
        /// </summary>
        internal static string Input_Rounding_SignificantFigures {
            get {
                return ResourceManager.GetString("Input.Rounding.SignificantFigures", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You didn&apos;t provide the number of Significant Figures you wanted, so we defaulted to.
        /// </summary>
        internal static string Input_Rounding_SignificantFigures_NotProvided {
            get {
                return ResourceManager.GetString("Input.Rounding.SignificantFigures.NotProvided", resourceCulture);
            }
        }
    }
}
