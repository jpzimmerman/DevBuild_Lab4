﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevBuild.SquaresAndCubes {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StringTable {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringTable() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DevBuild.SquaresAndCubes.StringTable", typeof(StringTable).Assembly);
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
        ///   Looks up a localized string similar to I couldn&apos;t read your input. Please enter y/n or yes/no.
        /// </summary>
        internal static string ContinueInputFailMessage {
            get {
                return ResourceManager.GetString("ContinueInputFailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Continue? (y/n).
        /// </summary>
        internal static string ContinueString {
            get {
                return ResourceManager.GetString("ContinueString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Here is a table of squares (n^2) and cubes (n^3) for that number:.
        /// </summary>
        internal static string CubesAndSquaresTableHeader {
            get {
                return ResourceManager.GetString("CubesAndSquaresTableHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter an integer: .
        /// </summary>
        internal static string EnterNumberString {
            get {
                return ResourceManager.GetString("EnterNumberString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks for checking some Squares and Cubes! Until next time....
        /// </summary>
        internal static string GoodbyeMessage {
            get {
                return ResourceManager.GetString("GoodbyeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hello!.
        /// </summary>
        internal static string HelloString {
            get {
                return ResourceManager.GetString("HelloString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I couldn&apos;t read your input. Please enter an integer..
        /// </summary>
        internal static string IntegerParseFailMessage {
            get {
                return ResourceManager.GetString("IntegerParseFailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Learn your Squares and Cubes!.
        /// </summary>
        internal static string TitleString {
            get {
                return ResourceManager.GetString("TitleString", resourceCulture);
            }
        }
    }
}
