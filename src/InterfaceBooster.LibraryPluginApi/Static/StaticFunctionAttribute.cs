using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBooster.LibraryPluginApi.Static
{
    /// <summary>
    /// Is used to mark a method as static function. The method must be public.
    /// </summary>
    public class StaticFunctionAttribute : Attribute
    {
        #region PRPOERTIES

        /// <summary>
        /// Gets or sets an alternative name for the function. (default = name of the method)
        /// </summary>
        public string AlternativeIdentifier { get; set; }

        #endregion

        #region PUBLIC METHODS

        /// <summary>
        /// Is used to mark a method as static function. The method must be public.
        /// </summary>
        public StaticFunctionAttribute() { }

        /// <summary>
        /// Is used to mark a method as static function. The method must be public.
        /// </summary>
        /// <param name="alternativeIdentifier">An alternative name for the function. (default = name of the method)</param>
        public StaticFunctionAttribute(string alternativeIdentifier)
        {
            AlternativeIdentifier = alternativeIdentifier;
        }

        #endregion
    }
}
