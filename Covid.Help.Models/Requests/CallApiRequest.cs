﻿namespace Covid.Help.Models.Requests
{
    public sealed class CallApiRequest
    {
        public string SipUsername { get; set; }
        public string SipDomain { get; set; }
        public string DialCallDuration { get; set; }
        public string DialCallSid { get; set; }
        public string DialCallStatus { get; set; }
        public string RecordingSid { get; set; }
        public string TranscriptionUrl { get; set; }
        public string TranscriptionStatus { get; set; }
        public string TranscriptionText { get; set; }
        public string TranscriptionSid { get; set; }
        public string RecordingSource { get; set; }
        public string SipCallId { get; set; }
        public int? RecordingChannels { get; set; }
        public string RecordingStatus { get; set; }
        public string RecordingUrl { get; set; }
        public float? Confidence { get; set; }
        public string SpeechResult { get; set; }
        public string Digits { get; set; }
        public string CallerName { get; set; }
        public string ForwardedFrom { get; set; }
        public string Direction { get; set; }
        public string ApiVersion { get; set; }
        public string CallStatus { get; set; }
        public string CallSid { get; set; }
        public string RecordingDuration { get; set; }
        public string SipSourceIp { get; set; }
        public string AccountSid { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string FromCity { get; set; }
        public string FromState { get; set; }
        public string FromZip { get; set; }
        public string FromCountry { get; set; }
        public string ToCity { get; set; }
        public string ToState { get; set; }
        public string ToZip { get; set; }
        public string ToCountry { get; set; }
    }
}