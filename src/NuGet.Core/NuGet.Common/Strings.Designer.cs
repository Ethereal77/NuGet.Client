﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Common {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Stride.Core.NuGet.NuGet.Common.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
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
        ///   Busca una cadena traducida similar a An absolute path is required: &apos;{0}&apos;..
        /// </summary>
        internal static string AbsolutePathRequired {
            get {
                return ResourceManager.GetString("AbsolutePathRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Value must be greater than or equal to {0}.
        /// </summary>
        internal static string Argument_Must_Be_GreaterThanOrEqualTo {
            get {
                return ResourceManager.GetString("Argument_Must_Be_GreaterThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Argument cannot be null or empty.
        /// </summary>
        internal static string ArgumentNullOrEmpty {
            get {
                return ResourceManager.GetString("ArgumentNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Failed to create random file for dotnet add pkg command..
        /// </summary>
        internal static string Error_FailedToCreateRandomFile {
            get {
                return ResourceManager.GetString("Error_FailedToCreateRandomFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Required environment variable &apos;{0}&apos; is not set. Try setting &apos;{0}&apos; and running the operation again..
        /// </summary>
        internal static string MissingRequiredEnvVar {
            get {
                return ResourceManager.GetString("MissingRequiredEnvVar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Required environment variable &apos;{0}&apos; is not set. Try setting &apos;{1}&apos; or &apos;{0}&apos; and running the operation.
        /// </summary>
        internal static string MissingRequiredEnvVarsDotnet {
            get {
                return ResourceManager.GetString("MissingRequiredEnvVarsDotnet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a At least one package folder path must be provided..
        /// </summary>
        internal static string NoPackageFoldersFound {
            get {
                return ResourceManager.GetString("NoPackageFoldersFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Package folder not found: &apos;{0}&apos;..
        /// </summary>
        internal static string PackageFolderNotFound {
            get {
                return ResourceManager.GetString("PackageFolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Unable to determine the current NuGet client version..
        /// </summary>
        internal static string UnableToDetemineClientVersion {
            get {
                return ResourceManager.GetString("UnableToDetemineClientVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Unable to obtain lock file access on &apos;{0}&apos; for operations on &apos;{1}&apos;. This may mean that a different user or administrator is holding this lock and that this process does not have permission to access it. If no other process is currently performing an operation on this file it may mean that an earlier NuGet process crashed and left an inaccessible lock file, in this case removing the file &apos;{0}&apos; will allow NuGet to continue..
        /// </summary>
        internal static string UnauthorizedLockFail {
            get {
                return ResourceManager.GetString("UnauthorizedLockFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Hash algorithm &apos;{0}&apos; is unsupported. Supported algorithms include: SHA512 and SHA256..
        /// </summary>
        internal static string UnsupportedHashAlgorithm {
            get {
                return ResourceManager.GetString("UnsupportedHashAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Hash algorithm &apos;{0}&apos; is unsupported..
        /// </summary>
        internal static string UnsupportedHashAlgorithmName {
            get {
                return ResourceManager.GetString("UnsupportedHashAlgorithmName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Signature algorithm &apos;{0}&apos; is unsupported..
        /// </summary>
        internal static string UnsupportedSignatureAlgorithmName {
            get {
                return ResourceManager.GetString("UnsupportedSignatureAlgorithmName", resourceCulture);
            }
        }
    }
}
