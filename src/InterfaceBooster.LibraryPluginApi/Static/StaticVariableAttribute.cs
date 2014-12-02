using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBooster.LibraryPluginApi.Static
{
    /// <summary>
    /// Is used to mark a property as static variable. At least the getter or the setter of the property must be public.
    /// </summary>
    public class StaticVariableAttribute : Attribute
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets an alternative name for the variable. (default = name of the property)
        /// </summary>
        public string AlternativeIdentifier { get; set; }

        #endregion

        #region PUBLIC METHODS

        /// <summary>
        /// Is used to mark a property as static variable. At least the getter or the setter of the property must be public.
        /// </summary>
        public StaticVariableAttribute() { }
        
        /// <summary>
        /// Is used to mark a property as static variable. At least the getter or the setter of the property must be public.
        /// </summary>
        /// <param name="alternativeIdentifier">An alternative name for the variable. (default = name of the property)</param>
        public StaticVariableAttribute(string alternativeIdentifier)
        {
            AlternativeIdentifier = alternativeIdentifier;
        }

        #endregion
    }
}
