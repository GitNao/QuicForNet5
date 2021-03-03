namespace System.Net.Quic {
    using System;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QuicForNet5.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string net_quic_addressfamily_notsupported {
            get {
                return ResourceManager.GetString("net_quic_addressfamily_notsupported", resourceCulture);
            }
        }
        
        internal static string net_quic_connectionaborted {
            get {
                return ResourceManager.GetString("net_quic_connectionaborted", resourceCulture);
            }
        }
        
        internal static string net_quic_noloopback {
            get {
                return ResourceManager.GetString("net_quic_noloopback", resourceCulture);
            }
        }
        
        internal static string net_quic_notsupported {
            get {
                return ResourceManager.GetString("net_quic_notsupported", resourceCulture);
            }
        }
        
        internal static string net_quic_operationaborted {
            get {
                return ResourceManager.GetString("net_quic_operationaborted", resourceCulture);
            }
        }
        
        internal static string net_quic_reading_notallowed {
            get {
                return ResourceManager.GetString("net_quic_reading_notallowed", resourceCulture);
            }
        }
        
        internal static string net_quic_sending_aborted {
            get {
                return ResourceManager.GetString("net_quic_sending_aborted", resourceCulture);
            }
        }
        
        internal static string net_quic_streamaborted {
            get {
                return ResourceManager.GetString("net_quic_streamaborted", resourceCulture);
            }
        }
        
        internal static string net_quic_unsupported_address_family {
            get {
                return ResourceManager.GetString("net_quic_unsupported_address_family", resourceCulture);
            }
        }
        
        internal static string net_quic_writing_notallowed {
            get {
                return ResourceManager.GetString("net_quic_writing_notallowed", resourceCulture);
            }
        }
        
        internal static string SystemNetQuic_PlatformNotSupported {
            get {
                return ResourceManager.GetString("SystemNetQuic_PlatformNotSupported", resourceCulture);
            }
        }
    }
}
