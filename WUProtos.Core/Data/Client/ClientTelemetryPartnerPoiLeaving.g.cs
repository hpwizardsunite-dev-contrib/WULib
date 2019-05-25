// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryPartnerPoiLeaving.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryPartnerPoiLeaving.proto</summary>
  public static partial class ClientTelemetryPartnerPoiLeavingReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryPartnerPoiLeaving.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryPartnerPoiLeavingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlQYXJ0bmVy",
            "UG9pTGVhdmluZy5wcm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQicgogQ2xp",
            "ZW50VGVsZW1ldHJ5UGFydG5lclBvaUxlYXZpbmcSDgoGcG9pX2lkGAEgASgJ",
            "EhIKCnBhcnRuZXJfaWQYAiABKAkSEwoLdGltZV9pbl9wb2kYAyABKAMSFQoN",
            "dGltZV9pbl9yYW5nZRgEIAEoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryPartnerPoiLeaving), global::WUProtos.Data.Client.ClientTelemetryPartnerPoiLeaving.Parser, new[]{ "PoiId", "PartnerId", "TimeInPoi", "TimeInRange" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryPartnerPoiLeaving : pb::IMessage<ClientTelemetryPartnerPoiLeaving> {
    private static readonly pb::MessageParser<ClientTelemetryPartnerPoiLeaving> _parser = new pb::MessageParser<ClientTelemetryPartnerPoiLeaving>(() => new ClientTelemetryPartnerPoiLeaving());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryPartnerPoiLeaving> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryPartnerPoiLeavingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryPartnerPoiLeaving() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryPartnerPoiLeaving(ClientTelemetryPartnerPoiLeaving other) : this() {
      poiId_ = other.poiId_;
      partnerId_ = other.partnerId_;
      timeInPoi_ = other.timeInPoi_;
      timeInRange_ = other.timeInRange_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryPartnerPoiLeaving Clone() {
      return new ClientTelemetryPartnerPoiLeaving(this);
    }

    /// <summary>Field number for the "poi_id" field.</summary>
    public const int PoiIdFieldNumber = 1;
    private string poiId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PoiId {
      get { return poiId_; }
      set {
        poiId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "partner_id" field.</summary>
    public const int PartnerIdFieldNumber = 2;
    private string partnerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PartnerId {
      get { return partnerId_; }
      set {
        partnerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time_in_poi" field.</summary>
    public const int TimeInPoiFieldNumber = 3;
    private long timeInPoi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TimeInPoi {
      get { return timeInPoi_; }
      set {
        timeInPoi_ = value;
      }
    }

    /// <summary>Field number for the "time_in_range" field.</summary>
    public const int TimeInRangeFieldNumber = 4;
    private long timeInRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TimeInRange {
      get { return timeInRange_; }
      set {
        timeInRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryPartnerPoiLeaving);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryPartnerPoiLeaving other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PoiId != other.PoiId) return false;
      if (PartnerId != other.PartnerId) return false;
      if (TimeInPoi != other.TimeInPoi) return false;
      if (TimeInRange != other.TimeInRange) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PoiId.Length != 0) hash ^= PoiId.GetHashCode();
      if (PartnerId.Length != 0) hash ^= PartnerId.GetHashCode();
      if (TimeInPoi != 0L) hash ^= TimeInPoi.GetHashCode();
      if (TimeInRange != 0L) hash ^= TimeInRange.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PoiId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PoiId);
      }
      if (PartnerId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PartnerId);
      }
      if (TimeInPoi != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(TimeInPoi);
      }
      if (TimeInRange != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(TimeInRange);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PoiId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PoiId);
      }
      if (PartnerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PartnerId);
      }
      if (TimeInPoi != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TimeInPoi);
      }
      if (TimeInRange != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TimeInRange);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryPartnerPoiLeaving other) {
      if (other == null) {
        return;
      }
      if (other.PoiId.Length != 0) {
        PoiId = other.PoiId;
      }
      if (other.PartnerId.Length != 0) {
        PartnerId = other.PartnerId;
      }
      if (other.TimeInPoi != 0L) {
        TimeInPoi = other.TimeInPoi;
      }
      if (other.TimeInRange != 0L) {
        TimeInRange = other.TimeInRange;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            PoiId = input.ReadString();
            break;
          }
          case 18: {
            PartnerId = input.ReadString();
            break;
          }
          case 24: {
            TimeInPoi = input.ReadInt64();
            break;
          }
          case 32: {
            TimeInRange = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
