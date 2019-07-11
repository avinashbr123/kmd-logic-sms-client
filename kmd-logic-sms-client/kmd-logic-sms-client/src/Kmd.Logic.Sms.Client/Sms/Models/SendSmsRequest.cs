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

    public partial class SendSmsRequest
    {
        /// <summary>
        /// Initializes a new instance of the SendSmsRequest class.
        /// </summary>
        public SendSmsRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SendSmsRequest class.
        /// </summary>
        /// <param name="toPhoneNumber">Phone number of recipient example
        /// accepted phone number: +4537360734</param>
        /// <param name="body">The text of the SMS message</param>
        /// <param name="callbackUrl">If provided, this URL endpoint will
        /// receive a POST request when there is any
        /// change of the SMS message status (e.g. sending, sent and
        /// failed).</param>
        /// <param name="providerConfigurationId">A unique identifier that
        /// represents the SMS provider and
        /// associated configuration which this SMS message will be sent
        /// with.</param>
        public SendSmsRequest(string toPhoneNumber, string body, string callbackUrl = default(string), System.Guid? providerConfigurationId = default(System.Guid?))
        {
            ToPhoneNumber = toPhoneNumber;
            Body = body;
            CallbackUrl = callbackUrl;
            ProviderConfigurationId = providerConfigurationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets phone number of recipient example accepted phone
        /// number: +4537360734
        /// </summary>
        [JsonProperty(PropertyName = "toPhoneNumber")]
        public string ToPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the text of the SMS message
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets if provided, this URL endpoint will receive a POST
        /// request when there is any
        /// change of the SMS message status (e.g. sending, sent and failed).
        /// </summary>
        [JsonProperty(PropertyName = "callbackUrl")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or sets a unique identifier that represents the SMS provider
        /// and
        /// associated configuration which this SMS message will be sent with.
        /// </summary>
        [JsonProperty(PropertyName = "providerConfigurationId")]
        public System.Guid? ProviderConfigurationId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ToPhoneNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ToPhoneNumber");
            }
            if (Body == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Body");
            }
            if (ToPhoneNumber != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(ToPhoneNumber, "^\\+?[1-9]\\d{1,14}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ToPhoneNumber", "^\\+?[1-9]\\d{1,14}$");
                }
            }
            if (Body != null)
            {
                if (Body.Length > 1600)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Body", 1600);
                }
                if (Body.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Body", 1);
                }
            }
        }
    }
}
