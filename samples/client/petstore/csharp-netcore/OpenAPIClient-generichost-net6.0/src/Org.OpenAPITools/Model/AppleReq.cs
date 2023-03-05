// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// AppleReq
    /// </summary>
    public partial class AppleReq : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleReq" /> class.
        /// </summary>
        /// <param name="cultivar">cultivar</param>
        /// <param name="mealy">mealy</param>
        [JsonConstructor]
        public AppleReq(string cultivar, bool mealy)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (cultivar == null)
                throw new ArgumentNullException("cultivar is a required property for AppleReq and cannot be null.");

            if (mealy == null)
                throw new ArgumentNullException("mealy is a required property for AppleReq and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Cultivar = cultivar;
            Mealy = mealy;
        }

        /// <summary>
        /// Gets or Sets Cultivar
        /// </summary>
        [JsonPropertyName("cultivar")]
        public string Cultivar { get; set; }

        /// <summary>
        /// Gets or Sets Mealy
        /// </summary>
        [JsonPropertyName("mealy")]
        public bool Mealy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppleReq {\n");
            sb.Append("  Cultivar: ").Append(Cultivar).Append("\n");
            sb.Append("  Mealy: ").Append(Mealy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type AppleReq
    /// </summary>
    public class AppleReqJsonConverter : JsonConverter<AppleReq>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AppleReq Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string cultivar = default;
            bool mealy = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "cultivar":
                            cultivar = utf8JsonReader.GetString();
                            break;
                        case "mealy":
                            mealy = utf8JsonReader.GetBoolean();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new AppleReq(cultivar, mealy);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="appleReq"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AppleReq appleReq, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("cultivar", appleReq.Cultivar);
            writer.WriteBoolean("mealy", appleReq.Mealy);

            writer.WriteEndObject();
        }
    }
}