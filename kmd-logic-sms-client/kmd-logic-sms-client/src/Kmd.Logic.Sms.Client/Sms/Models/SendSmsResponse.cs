// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Api.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SendSmsResponse
    {
        /// <summary>
        /// Initializes a new instance of the SendSmsResponse class.
        /// </summary>
        public SendSmsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SendSmsResponse class.
        /// </summary>
        /// <param name="smsMessageId">A unique identifier for the SMS
        /// message.</param>
        public SendSmsResponse(System.Guid smsMessageId)
        {
            SmsMessageId = smsMessageId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a unique identifier for the SMS message.
        /// </summary>
        [JsonProperty(PropertyName = "smsMessageId")]
        public System.Guid SmsMessageId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
