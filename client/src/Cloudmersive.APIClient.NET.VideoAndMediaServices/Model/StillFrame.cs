/* 
 * videoapi
 *
 * The video APIs help you convert, encode, and transcode videos.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NET.VideoAndMediaServices.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.VideoAndMediaServices.Model
{
    /// <summary>
    /// A single still frame from a video
    /// </summary>
    [DataContract]
    public partial class StillFrame :  IEquatable<StillFrame>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StillFrame" /> class.
        /// </summary>
        /// <param name="frameNumber">The number of the current frame.</param>
        /// <param name="timeStamp">The playback time of the current frame.</param>
        /// <param name="content">The still frame in PNG format as a byte array.</param>
        public StillFrame(int? frameNumber = default(int?), string timeStamp = default(string), byte[] content = default(byte[]))
        {
            this.FrameNumber = frameNumber;
            this.TimeStamp = timeStamp;
            this.Content = content;
        }
        
        /// <summary>
        /// The number of the current frame
        /// </summary>
        /// <value>The number of the current frame</value>
        [DataMember(Name="FrameNumber", EmitDefaultValue=false)]
        public int? FrameNumber { get; set; }

        /// <summary>
        /// The playback time of the current frame
        /// </summary>
        /// <value>The playback time of the current frame</value>
        [DataMember(Name="TimeStamp", EmitDefaultValue=false)]
        public string TimeStamp { get; set; }

        /// <summary>
        /// The still frame in PNG format as a byte array
        /// </summary>
        /// <value>The still frame in PNG format as a byte array</value>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public byte[] Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StillFrame {\n");
            sb.Append("  FrameNumber: ").Append(FrameNumber).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StillFrame);
        }

        /// <summary>
        /// Returns true if StillFrame instances are equal
        /// </summary>
        /// <param name="input">Instance of StillFrame to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StillFrame input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FrameNumber == input.FrameNumber ||
                    (this.FrameNumber != null &&
                    this.FrameNumber.Equals(input.FrameNumber))
                ) && 
                (
                    this.TimeStamp == input.TimeStamp ||
                    (this.TimeStamp != null &&
                    this.TimeStamp.Equals(input.TimeStamp))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                );
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
                if (this.FrameNumber != null)
                    hashCode = hashCode * 59 + this.FrameNumber.GetHashCode();
                if (this.TimeStamp != null)
                    hashCode = hashCode * 59 + this.TimeStamp.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
