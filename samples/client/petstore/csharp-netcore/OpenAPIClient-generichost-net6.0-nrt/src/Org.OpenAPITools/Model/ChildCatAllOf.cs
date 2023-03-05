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
    /// ChildCatAllOf
    /// </summary>
    public partial class ChildCatAllOf : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildCatAllOf" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="petType">petType (default to PetTypeEnum.ChildCat)</param>
        [JsonConstructor]
        public ChildCatAllOf(string name, PetTypeEnum petType = PetTypeEnum.ChildCat)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (name == null)
                throw new ArgumentNullException("name is a required property for ChildCatAllOf and cannot be null.");

            if (petType == null)
                throw new ArgumentNullException("petType is a required property for ChildCatAllOf and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Name = name;
            PetType = petType;
        }

        /// <summary>
        /// Defines PetType
        /// </summary>
        public enum PetTypeEnum
        {
            /// <summary>
            /// Enum ChildCat for value: ChildCat
            /// </summary>
            ChildCat = 1

        }

        /// <summary>
        /// Returns a PetTypeEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static PetTypeEnum PetTypeEnumFromString(string value)
        {
            if (value == "ChildCat")
                return PetTypeEnum.ChildCat;

            throw new NotImplementedException($"Could not convert value to type PetTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string PetTypeEnumToJsonValue(PetTypeEnum value)
        {
            if (value == PetTypeEnum.ChildCat)
                return "ChildCat";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets PetType
        /// </summary>
        [JsonPropertyName("pet_type")]
        public PetTypeEnum PetType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

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
            sb.Append("class ChildCatAllOf {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PetType: ").Append(PetType).Append("\n");
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
    /// A Json converter for type ChildCatAllOf
    /// </summary>
    public class ChildCatAllOfJsonConverter : JsonConverter<ChildCatAllOf>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ChildCatAllOf Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string name = default;
            ChildCatAllOf.PetTypeEnum petType = default;

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
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "pet_type":
                            string petTypeRawValue = utf8JsonReader.GetString();
                            petType = ChildCatAllOf.PetTypeEnumFromString(petTypeRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ChildCatAllOf(name, petType);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="childCatAllOf"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ChildCatAllOf childCatAllOf, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("name", childCatAllOf.Name);
            var petTypeRawValue = ChildCatAllOf.PetTypeEnumToJsonValue(childCatAllOf.PetType);
            if (petTypeRawValue != null)
                writer.WriteString("pet_type", petTypeRawValue);
            else
                writer.WriteNull("pet_type");

            writer.WriteEndObject();
        }
    }
}