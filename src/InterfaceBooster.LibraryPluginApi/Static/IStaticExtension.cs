using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBooster.LibraryPluginApi.Static
{
    /// <summary>
    /// Must be imlemented by classes that provide some static functions or variables
    /// </summary>
    public interface IStaticExtension
    {
        /// <summary>
        /// Gets a dot-separated path used to address all static functions and variables from this extension.
        /// It may not contain any white spaces or special chars that are not allowed in synery identifiers.
        /// Example: "Helpers.DataType.Strings"
        /// </summary>
        string Namespace { get; }
    }
}
