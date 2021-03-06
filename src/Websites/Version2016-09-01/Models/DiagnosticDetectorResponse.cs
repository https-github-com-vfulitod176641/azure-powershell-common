// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing Reponse from Diagnostic Detectors
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DiagnosticDetectorResponse : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticDetectorResponse class.
        /// </summary>
        public DiagnosticDetectorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiagnosticDetectorResponse class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="startTime">Start time of the period</param>
        /// <param name="endTime">End time of the period</param>
        /// <param name="issueDetected">Flag representing Issue was
        /// detected.</param>
        /// <param name="detectorDefinition">Detector's definition</param>
        /// <param name="metrics">Metrics provided by the detector</param>
        /// <param name="abnormalTimePeriods">List of Correlated events found
        /// by the detector</param>
        /// <param name="data">Additional Data that detector wants to
        /// send.</param>
        /// <param name="responseMetaData">Meta Data</param>
        public DiagnosticDetectorResponse(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), bool? issueDetected = default(bool?), DetectorDefinition detectorDefinition = default(DetectorDefinition), IList<DiagnosticMetricSet> metrics = default(IList<DiagnosticMetricSet>), IList<DetectorAbnormalTimePeriod> abnormalTimePeriods = default(IList<DetectorAbnormalTimePeriod>), IList<IList<NameValuePair>> data = default(IList<IList<NameValuePair>>), ResponseMetaData responseMetaData = default(ResponseMetaData))
            : base(id, name, kind, type)
        {
            StartTime = startTime;
            EndTime = endTime;
            IssueDetected = issueDetected;
            DetectorDefinition = detectorDefinition;
            Metrics = metrics;
            AbnormalTimePeriods = abnormalTimePeriods;
            Data = data;
            ResponseMetaData = responseMetaData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets start time of the period
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time of the period
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets flag representing Issue was detected.
        /// </summary>
        [JsonProperty(PropertyName = "properties.issueDetected")]
        public bool? IssueDetected { get; set; }

        /// <summary>
        /// Gets or sets detector's definition
        /// </summary>
        [JsonProperty(PropertyName = "properties.detectorDefinition")]
        public DetectorDefinition DetectorDefinition { get; set; }

        /// <summary>
        /// Gets or sets metrics provided by the detector
        /// </summary>
        [JsonProperty(PropertyName = "properties.metrics")]
        public IList<DiagnosticMetricSet> Metrics { get; set; }

        /// <summary>
        /// Gets or sets list of Correlated events found by the detector
        /// </summary>
        [JsonProperty(PropertyName = "properties.abnormalTimePeriods")]
        public IList<DetectorAbnormalTimePeriod> AbnormalTimePeriods { get; set; }

        /// <summary>
        /// Gets or sets additional Data that detector wants to send.
        /// </summary>
        [JsonProperty(PropertyName = "properties.data")]
        public IList<IList<NameValuePair>> Data { get; set; }

        /// <summary>
        /// Gets or sets meta Data
        /// </summary>
        [JsonProperty(PropertyName = "properties.responseMetaData")]
        public ResponseMetaData ResponseMetaData { get; set; }

    }
}
