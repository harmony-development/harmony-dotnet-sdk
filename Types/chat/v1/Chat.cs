// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: chat/v1/chat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Harmony.Chat.V1 {

  /// <summary>Holder for reflection information generated from chat/v1/chat.proto</summary>
  public static partial class ChatReflection {

    #region Descriptor
    /// <summary>File descriptor for chat/v1/chat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJjaGF0L3YxL2NoYXQucHJvdG8SEHByb3RvY29sLmNoYXQudjEaG2hhcm1v",
            "bnl0eXBlcy92MS90eXBlcy5wcm90bxoUY2hhdC92MS9ndWlsZHMucHJvdG8a",
            "FmNoYXQvdjEvY2hhbm5lbHMucHJvdG8aFmNoYXQvdjEvbWVzc2FnZXMucHJv",
            "dG8aGWNoYXQvdjEvcGVybWlzc2lvbnMucHJvdG8aFGNoYXQvdjEvc3RyZWFt",
            "LnByb3RvMsczCgtDaGF0U2VydmljZRJhCgtDcmVhdGVHdWlsZBIkLnByb3Rv",
            "Y29sLmNoYXQudjEuQ3JlYXRlR3VpbGRSZXF1ZXN0GiUucHJvdG9jb2wuY2hh",
            "dC52MS5DcmVhdGVHdWlsZFJlc3BvbnNlIgWaRAIIARJeCgpDcmVhdGVSb29t",
            "EiMucHJvdG9jb2wuY2hhdC52MS5DcmVhdGVSb29tUmVxdWVzdBokLnByb3Rv",
            "Y29sLmNoYXQudjEuQ3JlYXRlUm9vbVJlc3BvbnNlIgWaRAIIARJ5ChNDcmVh",
            "dGVEaXJlY3RNZXNzYWdlEiwucHJvdG9jb2wuY2hhdC52MS5DcmVhdGVEaXJl",
            "Y3RNZXNzYWdlUmVxdWVzdBotLnByb3RvY29sLmNoYXQudjEuQ3JlYXRlRGly",
            "ZWN0TWVzc2FnZVJlc3BvbnNlIgWaRAIIARJ7ChJVcGdyYWRlUm9vbVRvR3Vp",
            "bGQSKy5wcm90b2NvbC5jaGF0LnYxLlVwZ3JhZGVSb29tVG9HdWlsZFJlcXVl",
            "c3QaLC5wcm90b2NvbC5jaGF0LnYxLlVwZ3JhZGVSb29tVG9HdWlsZFJlc3Bv",
            "bnNlIgqaRAIIAZpEAiABEn4KDENyZWF0ZUludml0ZRIlLnByb3RvY29sLmNo",
            "YXQudjEuQ3JlYXRlSW52aXRlUmVxdWVzdBomLnByb3RvY29sLmNoYXQudjEu",
            "Q3JlYXRlSW52aXRlUmVzcG9uc2UiH5pEAggBmkQXGhVpbnZpdGVzLm1hbmFn",
            "ZS5jcmVhdGUSggEKDUNyZWF0ZUNoYW5uZWwSJi5wcm90b2NvbC5jaGF0LnYx",
            "LkNyZWF0ZUNoYW5uZWxSZXF1ZXN0GicucHJvdG9jb2wuY2hhdC52MS5DcmVh",
            "dGVDaGFubmVsUmVzcG9uc2UiIJpEAggBmkQYGhZjaGFubmVscy5tYW5hZ2Uu",
            "Y3JlYXRlEmQKDEdldEd1aWxkTGlzdBIlLnByb3RvY29sLmNoYXQudjEuR2V0",
            "R3VpbGRMaXN0UmVxdWVzdBomLnByb3RvY29sLmNoYXQudjEuR2V0R3VpbGRM",
            "aXN0UmVzcG9uc2UiBZpEAggBEo0BChFJbnZpdGVVc2VyVG9HdWlsZBIqLnBy",
            "b3RvY29sLmNoYXQudjEuSW52aXRlVXNlclRvR3VpbGRSZXF1ZXN0GisucHJv",
            "dG9jb2wuY2hhdC52MS5JbnZpdGVVc2VyVG9HdWlsZFJlc3BvbnNlIh+aRAII",
            "AZpEFxoVaW52aXRlcy5tYW5hZ2UuY3JlYXRlEnMKEUdldFBlbmRpbmdJbnZp",
            "dGVzEioucHJvdG9jb2wuY2hhdC52MS5HZXRQZW5kaW5nSW52aXRlc1JlcXVl",
            "c3QaKy5wcm90b2NvbC5jaGF0LnYxLkdldFBlbmRpbmdJbnZpdGVzUmVzcG9u",
            "c2UiBZpEAggBEnkKE1JlamVjdFBlbmRpbmdJbnZpdGUSLC5wcm90b2NvbC5j",
            "aGF0LnYxLlJlamVjdFBlbmRpbmdJbnZpdGVSZXF1ZXN0Gi0ucHJvdG9jb2wu",
            "Y2hhdC52MS5SZWplY3RQZW5kaW5nSW52aXRlUmVzcG9uc2UiBZpEAggBEnkK",
            "E0lnbm9yZVBlbmRpbmdJbnZpdGUSLC5wcm90b2NvbC5jaGF0LnYxLklnbm9y",
            "ZVBlbmRpbmdJbnZpdGVSZXF1ZXN0Gi0ucHJvdG9jb2wuY2hhdC52MS5JZ25v",
            "cmVQZW5kaW5nSW52aXRlUmVzcG9uc2UiBZpEAggBElgKCEdldEd1aWxkEiEu",
            "cHJvdG9jb2wuY2hhdC52MS5HZXRHdWlsZFJlcXVlc3QaIi5wcm90b2NvbC5j",
            "aGF0LnYxLkdldEd1aWxkUmVzcG9uc2UiBZpEAggBEn4KD0dldEd1aWxkSW52",
            "aXRlcxIoLnByb3RvY29sLmNoYXQudjEuR2V0R3VpbGRJbnZpdGVzUmVxdWVz",
            "dBopLnByb3RvY29sLmNoYXQudjEuR2V0R3VpbGRJbnZpdGVzUmVzcG9uc2Ui",
            "FppEAggBmkQOGgxpbnZpdGVzLnZpZXcSbQoPR2V0R3VpbGRNZW1iZXJzEigu",
            "cHJvdG9jb2wuY2hhdC52MS5HZXRHdWlsZE1lbWJlcnNSZXF1ZXN0GikucHJv",
            "dG9jb2wuY2hhdC52MS5HZXRHdWlsZE1lbWJlcnNSZXNwb25zZSIFmkQCCAES",
            "cAoQR2V0R3VpbGRDaGFubmVscxIpLnByb3RvY29sLmNoYXQudjEuR2V0R3Vp",
            "bGRDaGFubmVsc1JlcXVlc3QaKi5wcm90b2NvbC5jaGF0LnYxLkdldEd1aWxk",
            "Q2hhbm5lbHNSZXNwb25zZSIFmkQCCAESiAEKEkdldENoYW5uZWxNZXNzYWdl",
            "cxIrLnByb3RvY29sLmNoYXQudjEuR2V0Q2hhbm5lbE1lc3NhZ2VzUmVxdWVz",
            "dBosLnByb3RvY29sLmNoYXQudjEuR2V0Q2hhbm5lbE1lc3NhZ2VzUmVzcG9u",
            "c2UiF5pEAggBmkQPGg1tZXNzYWdlcy52aWV3EnAKCkdldE1lc3NhZ2USIy5w",
            "cm90b2NvbC5jaGF0LnYxLkdldE1lc3NhZ2VSZXF1ZXN0GiQucHJvdG9jb2wu",
            "Y2hhdC52MS5HZXRNZXNzYWdlUmVzcG9uc2UiF5pEAggBmkQPGg1tZXNzYWdl",
            "cy52aWV3EqYBChZVcGRhdGVHdWlsZEluZm9ybWF0aW9uEi8ucHJvdG9jb2wu",
            "Y2hhdC52MS5VcGRhdGVHdWlsZEluZm9ybWF0aW9uUmVxdWVzdBowLnByb3Rv",
            "Y29sLmNoYXQudjEuVXBkYXRlR3VpbGRJbmZvcm1hdGlvblJlc3BvbnNlIima",
            "RAIIAZpEIRofZ3VpbGQubWFuYWdlLmNoYW5nZS1pbmZvcm1hdGlvbhKvAQoY",
            "VXBkYXRlQ2hhbm5lbEluZm9ybWF0aW9uEjEucHJvdG9jb2wuY2hhdC52MS5V",
            "cGRhdGVDaGFubmVsSW5mb3JtYXRpb25SZXF1ZXN0GjIucHJvdG9jb2wuY2hh",
            "dC52MS5VcGRhdGVDaGFubmVsSW5mb3JtYXRpb25SZXNwb25zZSIsmkQCCAGa",
            "RCQaImNoYW5uZWxzLm1hbmFnZS5jaGFuZ2UtaW5mb3JtYXRpb24SjwEKElVw",
            "ZGF0ZUNoYW5uZWxPcmRlchIrLnByb3RvY29sLmNoYXQudjEuVXBkYXRlQ2hh",
            "bm5lbE9yZGVyUmVxdWVzdBosLnByb3RvY29sLmNoYXQudjEuVXBkYXRlQ2hh",
            "bm5lbE9yZGVyUmVzcG9uc2UiHppEAggBmkQWGhRjaGFubmVscy5tYW5hZ2Uu",
            "bW92ZRKYAQoVVXBkYXRlQWxsQ2hhbm5lbE9yZGVyEi4ucHJvdG9jb2wuY2hh",
            "dC52MS5VcGRhdGVBbGxDaGFubmVsT3JkZXJSZXF1ZXN0Gi8ucHJvdG9jb2wu",
            "Y2hhdC52MS5VcGRhdGVBbGxDaGFubmVsT3JkZXJSZXNwb25zZSIemkQCCAGa",
            "RBYaFGNoYW5uZWxzLm1hbmFnZS5tb3ZlEoUBChFVcGRhdGVNZXNzYWdlVGV4",
            "dBIqLnByb3RvY29sLmNoYXQudjEuVXBkYXRlTWVzc2FnZVRleHRSZXF1ZXN0",
            "GisucHJvdG9jb2wuY2hhdC52MS5VcGRhdGVNZXNzYWdlVGV4dFJlc3BvbnNl",
            "IheaRAIIAZpEDxoNbWVzc2FnZXMuc2VuZBJmCgtEZWxldGVHdWlsZBIkLnBy",
            "b3RvY29sLmNoYXQudjEuRGVsZXRlR3VpbGRSZXF1ZXN0GiUucHJvdG9jb2wu",
            "Y2hhdC52MS5EZWxldGVHdWlsZFJlc3BvbnNlIgqaRAIIAZpEAiABEn4KDERl",
            "bGV0ZUludml0ZRIlLnByb3RvY29sLmNoYXQudjEuRGVsZXRlSW52aXRlUmVx",
            "dWVzdBomLnByb3RvY29sLmNoYXQudjEuRGVsZXRlSW52aXRlUmVzcG9uc2Ui",
            "H5pEAggBmkQXGhVpbnZpdGVzLm1hbmFnZS5kZWxldGUSggEKDURlbGV0ZUNo",
            "YW5uZWwSJi5wcm90b2NvbC5jaGF0LnYxLkRlbGV0ZUNoYW5uZWxSZXF1ZXN0",
            "GicucHJvdG9jb2wuY2hhdC52MS5EZWxldGVDaGFubmVsUmVzcG9uc2UiIJpE",
            "AggBmkQYGhZjaGFubmVscy5tYW5hZ2UuZGVsZXRlEmcKDURlbGV0ZU1lc3Nh",
            "Z2USJi5wcm90b2NvbC5jaGF0LnYxLkRlbGV0ZU1lc3NhZ2VSZXF1ZXN0Gicu",
            "cHJvdG9jb2wuY2hhdC52MS5EZWxldGVNZXNzYWdlUmVzcG9uc2UiBZpEAggB",
            "ElsKCUpvaW5HdWlsZBIiLnByb3RvY29sLmNoYXQudjEuSm9pbkd1aWxkUmVx",
            "dWVzdBojLnByb3RvY29sLmNoYXQudjEuSm9pbkd1aWxkUmVzcG9uc2UiBZpE",
            "AggBEl4KCkxlYXZlR3VpbGQSIy5wcm90b2NvbC5jaGF0LnYxLkxlYXZlR3Vp",
            "bGRSZXF1ZXN0GiQucHJvdG9jb2wuY2hhdC52MS5MZWF2ZUd1aWxkUmVzcG9u",
            "c2UiBZpEAggBEnsKDVRyaWdnZXJBY3Rpb24SJi5wcm90b2NvbC5jaGF0LnYx",
            "LlRyaWdnZXJBY3Rpb25SZXF1ZXN0GicucHJvdG9jb2wuY2hhdC52MS5Ucmln",
            "Z2VyQWN0aW9uUmVzcG9uc2UiGZpEAggBmkQRGg9hY3Rpb25zLnRyaWdnZXIS",
            "cwoLU2VuZE1lc3NhZ2USJC5wcm90b2NvbC5jaGF0LnYxLlNlbmRNZXNzYWdl",
            "UmVxdWVzdBolLnByb3RvY29sLmNoYXQudjEuU2VuZE1lc3NhZ2VSZXNwb25z",
            "ZSIXmkQCCAGaRA8aDW1lc3NhZ2VzLnNlbmQSdgoSUXVlcnlIYXNQZXJtaXNz",
            "aW9uEisucHJvdG9jb2wuY2hhdC52MS5RdWVyeUhhc1Blcm1pc3Npb25SZXF1",
            "ZXN0GiwucHJvdG9jb2wuY2hhdC52MS5RdWVyeUhhc1Blcm1pc3Npb25SZXNw",
            "b25zZSIFmkQCCAEShQEKDlNldFBlcm1pc3Npb25zEicucHJvdG9jb2wuY2hh",
            "dC52MS5TZXRQZXJtaXNzaW9uc1JlcXVlc3QaKC5wcm90b2NvbC5jaGF0LnYx",
            "LlNldFBlcm1pc3Npb25zUmVzcG9uc2UiIJpEAggBmkQYGhZwZXJtaXNzaW9u",
            "cy5tYW5hZ2Uuc2V0EoUBCg5HZXRQZXJtaXNzaW9ucxInLnByb3RvY29sLmNo",
            "YXQudjEuR2V0UGVybWlzc2lvbnNSZXF1ZXN0GigucHJvdG9jb2wuY2hhdC52",
            "MS5HZXRQZXJtaXNzaW9uc1Jlc3BvbnNlIiCaRAIIAZpEGBoWcGVybWlzc2lv",
            "bnMubWFuYWdlLmdldBJpCghNb3ZlUm9sZRIhLnByb3RvY29sLmNoYXQudjEu",
            "TW92ZVJvbGVSZXF1ZXN0GiIucHJvdG9jb2wuY2hhdC52MS5Nb3ZlUm9sZVJl",
            "c3BvbnNlIhaaRAIIAZpEDhoMcm9sZXMubWFuYWdlEnUKDUdldEd1aWxkUm9s",
            "ZXMSJi5wcm90b2NvbC5jaGF0LnYxLkdldEd1aWxkUm9sZXNSZXF1ZXN0Gicu",
            "cHJvdG9jb2wuY2hhdC52MS5HZXRHdWlsZFJvbGVzUmVzcG9uc2UiE5pEAggB",
            "mkQLGglyb2xlcy5nZXQSdQoMQWRkR3VpbGRSb2xlEiUucHJvdG9jb2wuY2hh",
            "dC52MS5BZGRHdWlsZFJvbGVSZXF1ZXN0GiYucHJvdG9jb2wuY2hhdC52MS5B",
            "ZGRHdWlsZFJvbGVSZXNwb25zZSIWmkQCCAGaRA4aDHJvbGVzLm1hbmFnZRJ+",
            "Cg9Nb2RpZnlHdWlsZFJvbGUSKC5wcm90b2NvbC5jaGF0LnYxLk1vZGlmeUd1",
            "aWxkUm9sZVJlcXVlc3QaKS5wcm90b2NvbC5jaGF0LnYxLk1vZGlmeUd1aWxk",
            "Um9sZVJlc3BvbnNlIhaaRAIIAZpEDhoMcm9sZXMubWFuYWdlEn4KD0RlbGV0",
            "ZUd1aWxkUm9sZRIoLnByb3RvY29sLmNoYXQudjEuRGVsZXRlR3VpbGRSb2xl",
            "UmVxdWVzdBopLnByb3RvY29sLmNoYXQudjEuRGVsZXRlR3VpbGRSb2xlUmVz",
            "cG9uc2UiFppEAggBmkQOGgxyb2xlcy5tYW5hZ2USgwEKD01hbmFnZVVzZXJS",
            "b2xlcxIoLnByb3RvY29sLmNoYXQudjEuTWFuYWdlVXNlclJvbGVzUmVxdWVz",
            "dBopLnByb3RvY29sLmNoYXQudjEuTWFuYWdlVXNlclJvbGVzUmVzcG9uc2Ui",
            "G5pEAggBmkQTGhFyb2xlcy51c2VyLm1hbmFnZRJkCgxHZXRVc2VyUm9sZXMS",
            "JS5wcm90b2NvbC5jaGF0LnYxLkdldFVzZXJSb2xlc1JlcXVlc3QaJi5wcm90",
            "b2NvbC5jaGF0LnYxLkdldFVzZXJSb2xlc1Jlc3BvbnNlIgWaRAIIARJkCgZU",
            "eXBpbmcSHy5wcm90b2NvbC5jaGF0LnYxLlR5cGluZ1JlcXVlc3QaIC5wcm90",
            "b2NvbC5jaGF0LnYxLlR5cGluZ1Jlc3BvbnNlIheaRAIIAZpEDxoNbWVzc2Fn",
            "ZXMuc2VuZBJkCgxQcmV2aWV3R3VpbGQSJS5wcm90b2NvbC5jaGF0LnYxLlBy",
            "ZXZpZXdHdWlsZFJlcXVlc3QaJi5wcm90b2NvbC5jaGF0LnYxLlByZXZpZXdH",
            "dWlsZFJlc3BvbnNlIgWaRAIIABKOAQoOR2V0QmFubmVkVXNlcnMSJy5wcm90",
            "b2NvbC5jaGF0LnYxLkdldEJhbm5lZFVzZXJzUmVxdWVzdBooLnByb3RvY29s",
            "LmNoYXQudjEuR2V0QmFubmVkVXNlcnNSZXNwb25zZSIpmkQCCAGaRCEaH2d1",
            "aWxkLm1hbmFnZS5jaGFuZ2UtaW5mb3JtYXRpb24SaQoHQmFuVXNlchIgLnBy",
            "b3RvY29sLmNoYXQudjEuQmFuVXNlclJlcXVlc3QaIS5wcm90b2NvbC5jaGF0",
            "LnYxLkJhblVzZXJSZXNwb25zZSIZmkQCCAGaRBEaD3VzZXIubWFuYWdlLmJh",
            "bhJtCghLaWNrVXNlchIhLnByb3RvY29sLmNoYXQudjEuS2lja1VzZXJSZXF1",
            "ZXN0GiIucHJvdG9jb2wuY2hhdC52MS5LaWNrVXNlclJlc3BvbnNlIhqaRAII",
            "AZpEEhoQdXNlci5tYW5hZ2Uua2ljaxJxCglVbmJhblVzZXISIi5wcm90b2Nv",
            "bC5jaGF0LnYxLlVuYmFuVXNlclJlcXVlc3QaIy5wcm90b2NvbC5jaGF0LnYx",
            "LlVuYmFuVXNlclJlc3BvbnNlIhuaRAIIAZpEExoRdXNlci5tYW5hZ2UudW5i",
            "YW4ShQEKEUdldFBpbm5lZE1lc3NhZ2VzEioucHJvdG9jb2wuY2hhdC52MS5H",
            "ZXRQaW5uZWRNZXNzYWdlc1JlcXVlc3QaKy5wcm90b2NvbC5jaGF0LnYxLkdl",
            "dFBpbm5lZE1lc3NhZ2VzUmVzcG9uc2UiF5pEAggBmkQPGg1tZXNzYWdlcy52",
            "aWV3EnQKClBpbk1lc3NhZ2USIy5wcm90b2NvbC5jaGF0LnYxLlBpbk1lc3Nh",
            "Z2VSZXF1ZXN0GiQucHJvdG9jb2wuY2hhdC52MS5QaW5NZXNzYWdlUmVzcG9u",
            "c2UiG5pEAggBmkQTGhFtZXNzYWdlcy5waW5zLmFkZBJ9CgxVbnBpbk1lc3Nh",
            "Z2USJS5wcm90b2NvbC5jaGF0LnYxLlVucGluTWVzc2FnZVJlcXVlc3QaJi5w",
            "cm90b2NvbC5jaGF0LnYxLlVucGluTWVzc2FnZVJlc3BvbnNlIh6aRAIIAZpE",
            "FhoUbWVzc2FnZXMucGlucy5yZW1vdmUSaAoMU3RyZWFtRXZlbnRzEiUucHJv",
            "dG9jb2wuY2hhdC52MS5TdHJlYW1FdmVudHNSZXF1ZXN0GiYucHJvdG9jb2wu",
            "Y2hhdC52MS5TdHJlYW1FdmVudHNSZXNwb25zZSIFmkQCCAEoATABEnwKC0Fk",
            "ZFJlYWN0aW9uEiQucHJvdG9jb2wuY2hhdC52MS5BZGRSZWFjdGlvblJlcXVl",
            "c3QaJS5wcm90b2NvbC5jaGF0LnYxLkFkZFJlYWN0aW9uUmVzcG9uc2UiIJpE",
            "AggBmkQYGhZtZXNzYWdlcy5yZWFjdGlvbnMuYWRkEogBCg5SZW1vdmVSZWFj",
            "dGlvbhInLnByb3RvY29sLmNoYXQudjEuUmVtb3ZlUmVhY3Rpb25SZXF1ZXN0",
            "GigucHJvdG9jb2wuY2hhdC52MS5SZW1vdmVSZWFjdGlvblJlc3BvbnNlIiOa",
            "RAIIAZpEGxoZbWVzc2FnZXMucmVhY3Rpb25zLnJlbW92ZRJvCg5HcmFudE93",
            "bmVyc2hpcBInLnByb3RvY29sLmNoYXQudjEuR3JhbnRPd25lcnNoaXBSZXF1",
            "ZXN0GigucHJvdG9jb2wuY2hhdC52MS5HcmFudE93bmVyc2hpcFJlc3BvbnNl",
            "IgqaRAIIAZpEAiABEnIKD0dpdmVVcE93bmVyc2hpcBIoLnByb3RvY29sLmNo",
            "YXQudjEuR2l2ZVVwT3duZXJzaGlwUmVxdWVzdBopLnByb3RvY29sLmNoYXQu",
            "djEuR2l2ZVVwT3duZXJzaGlwUmVzcG9uc2UiCppEAggBmkQCIAFCM1oxZ2l0",
            "aHViLmNvbS9oYXJtb255LWRldmVsb3BtZW50L2xlZ2F0by9nZW4vY2hhdC92",
            "MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Harmony.Harmonytypes.V1.TypesReflection.Descriptor, global::Harmony.Chat.V1.GuildsReflection.Descriptor, global::Harmony.Chat.V1.ChannelsReflection.Descriptor, global::Harmony.Chat.V1.MessagesReflection.Descriptor, global::Harmony.Chat.V1.PermissionsReflection.Descriptor, global::Harmony.Chat.V1.StreamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code