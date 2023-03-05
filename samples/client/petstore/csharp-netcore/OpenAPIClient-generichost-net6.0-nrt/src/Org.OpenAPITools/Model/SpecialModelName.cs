// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
    /// SpecialModelName
    /// </summary>
    public partial class SpecialModelName : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialModelName" /> class.
        /// </summary>
        /// <param name="specialModelNameProperty">specialModelNameProperty</param>
        /// <param name="specialPropertyName">specialPropertyName</param>
        [JsonConstructor]
        public SpecialModelName(string specialModelNameProperty, long specialPropertyName)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (specialPropertyName == null)
                throw new ArgumentNullException("specialPropertyName is a required property for SpecialModelName and cannot be null.");

            if (specialModelNameProperty == null)
                throw new ArgumentNullException("specialModelNameProperty is a required property for SpecialModelName and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            SpecialModelNameProperty = specialModelNameProperty;
            SpecialPropertyName = specialPropertyName;
        }

        /// <summary>
        /// Gets or Sets SpecialModelNameProperty
        /// </summary>
        [JsonPropertyName("_special_model.name_")]
        public string SpecialModelNameProperty { get; set; }

        /// <summary>
        /// Gets or Sets SpecialPropertyName
        /// </summary>
        [JsonPropertyName("$special[property.name]")]
        public long SpecialPropertyName { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpecialModelName {\n");
            sb.Append("  SpecialModelNameProperty: ").Append(SpecialModelNameProperty).Append("\n");
            sb.Append("  SpecialPropertyName: ").Append(SpecialPropertyName).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
    /// A Json converter for type SpecialModelName
    /// </summary>
    public class SpecialModelNameJsonConverter : JsonConverter<SpecialModelName>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SpecialModelName Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string specialModelNameProperty = default;
            long specialPropertyName = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "_special_model.name_":
                            specialModelNameProperty = utf8JsonReader.GetString();
                            break;
                        case "$special[property.name]":
                            specialPropertyName = utf8JsonReader.GetInt64();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new SpecialModelName(specialModelNameProperty, specialPropertyName);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="specialModelName"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SpecialModelName specialModelName, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("_special_model.name_", specialModelName.SpecialModelNameProperty);
            writer.WriteNumber("$special[property.name]", specialModelName.SpecialPropertyName);

            writer.WriteEndObject();
        }
    }
}