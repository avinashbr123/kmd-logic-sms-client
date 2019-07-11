// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Api.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LogicProviderConfigurationRequestLogicProviderConfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LogicProviderConfigurationRequestLogicProviderConfig class.
        /// </summary>
        public LogicProviderConfigurationRequestLogicProviderConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LogicProviderConfigurationRequestLogicProviderConfig class.
        /// </summary>
        /// <param name="displayName">A custom name that can be used to later
        /// understand the purpose of
        /// this provider configuration.</param>
        /// <param name="configuration">The provider-specific
        /// configuration.</param>
        public LogicProviderConfigurationRequestLogicProviderConfig(string displayName, LogicProviderConfig configuration)
        {
            DisplayName = displayName;
            Configuration = configuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a custom name that can be used to later understand the
        /// purpose of
        /// this provider configuration.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the provider-specific configuration.
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public LogicProviderConfig Configuration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Configuration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Configuration");
            }
            if (Configuration != null)
            {
                Configuration.Validate();
            }
        }
    }
}
