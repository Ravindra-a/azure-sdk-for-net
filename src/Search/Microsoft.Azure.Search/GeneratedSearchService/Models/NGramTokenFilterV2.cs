// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Generates n-grams of the given size(s). This token filter is
    /// implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/ngram/NGramTokenFilter.html" />
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.NGramTokenFilterV2")]
    public partial class NGramTokenFilterV2 : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the NGramTokenFilterV2 class.
        /// </summary>
        public NGramTokenFilterV2() { }

        /// <summary>
        /// Initializes a new instance of the NGramTokenFilterV2 class.
        /// </summary>
        public NGramTokenFilterV2(string name, int? minGram = default(int?), int? maxGram = default(int?))
            : base(name)
        {
            MinGram = minGram;
            MaxGram = maxGram;
        }

        /// <summary>
        /// Gets or sets the minimum n-gram length. Default is 1. Maximum is
        /// 300. Must be less than the value of maxGram.
        /// </summary>
        [JsonProperty(PropertyName = "minGram")]
        public int? MinGram { get; set; }

        /// <summary>
        /// Gets or sets the maximum n-gram length. Default is 2. Maximum is
        /// 300.
        /// </summary>
        [JsonProperty(PropertyName = "maxGram")]
        public int? MaxGram { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.MinGram > 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MinGram", 300);
            }
            if (this.MaxGram > 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxGram", 300);
            }
        }
    }
}
