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
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Shape
    /// </summary>
    public partial class Shape : IEquatable<Shape>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shape" /> class.
        /// </summary>
        /// <param name="quadrilateral">quadrilateral</param>
        /// <param name="quadrilateralType">quadrilateralType (required)</param>
        public Shape(Quadrilateral quadrilateral, string quadrilateralType)
        {
            if (quadrilateralType == null)
                throw new ArgumentNullException("quadrilateralType is a required property for Shape and cannot be null.");

            Quadrilateral = quadrilateral;
            QuadrilateralType = quadrilateralType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape" /> class.
        /// </summary>
        /// <param name="triangle">triangle</param>
        /// <param name="quadrilateralType">quadrilateralType (required)</param>
        public Shape(Triangle triangle, string quadrilateralType)
        {
            if (quadrilateralType == null)
                throw new ArgumentNullException("quadrilateralType is a required property for Shape and cannot be null.");

            Triangle = triangle;
            QuadrilateralType = quadrilateralType;
        }

        /// <summary>
        /// Gets or Sets Shape
        /// </summary>
        public Quadrilateral Quadrilateral { get; set; }

        /// <summary>
        /// Gets or Sets Shape
        /// </summary>
        public Triangle Triangle { get; set; }

        /// <summary>
        /// Gets or Sets QuadrilateralType
        /// </summary>
        [JsonPropertyName("quadrilateralType")]
        public string QuadrilateralType { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; set; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Shape {\n");
            sb.Append("  QuadrilateralType: ").Append(QuadrilateralType).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Shape).AreEqual;
        }

        /// <summary>
        /// Returns true if Shape instances are equal
        /// </summary>
        /// <param name="input">Instance of Shape to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shape input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.QuadrilateralType != null)
                {
                    hashCode = (hashCode * 59) + this.QuadrilateralType.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type Shape
    /// </summary>
    public class ShapeJsonConverter : JsonConverter<Shape>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(Shape).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Shape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader quadrilateralReader = reader;
            Client.ClientUtils.TryDeserialize<Quadrilateral>(ref quadrilateralReader, options, out Quadrilateral quadrilateral);

            Utf8JsonReader triangleReader = reader;
            Client.ClientUtils.TryDeserialize<Triangle>(ref triangleReader, options, out Triangle triangle);

            string quadrilateralType = default;

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "quadrilateralType":
                            quadrilateralType = reader.GetString();
                            break;
                    }
                }
            }

            if (quadrilateral != null)
                return new Shape(quadrilateral, quadrilateralType);

            if (triangle != null)
                return new Shape(triangle, quadrilateralType);

            throw new JsonException();
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="shape"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Shape shape, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
