// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Pssg.Css.Interfaces.DynamicsAutorest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of csu_cclasection
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.csu_cclasectionCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMcsuCclasectionCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuCclasectionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuCclasectionCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuCclasectionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuCclasectionCollection(IList<MicrosoftDynamicsCRMcsuCclasection> value = default(IList<MicrosoftDynamicsCRMcsuCclasection>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMcsuCclasection> Value { get; set; }

    }
}
