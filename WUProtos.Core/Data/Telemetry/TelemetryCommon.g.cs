// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Telemetry/TelemetryCommon.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Telemetry {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Telemetry/TelemetryCommon.proto</summary>
  public static partial class TelemetryCommonReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Telemetry/TelemetryCommon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TelemetryCommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1XVVByb3Rvcy9EYXRhL1RlbGVtZXRyeS9UZWxlbWV0cnlDb21tb24ucHJv",
            "dG8SF1dVUHJvdG9zLkRhdGEuVGVsZW1ldHJ5IkAKD1RlbGVtZXRyeUNvbW1v",
            "bhIRCgl0aW1lc3RhbXAYASABKAMSGgoSY29ycmVsYXRpb25fdmVjdG9yGAIg",
            "ASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Telemetry.TelemetryCommon), global::WUProtos.Data.Telemetry.TelemetryCommon.Parser, new[]{ "Timestamp", "CorrelationVector" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TelemetryCommon : pb::IMessage<TelemetryCommon> {
    private static readonly pb::MessageParser<TelemetryCommon> _parser = new pb::MessageParser<TelemetryCommon>(() => new TelemetryCommon());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TelemetryCommon> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Telemetry.TelemetryCommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TelemetryCommon() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TelemetryCommon(TelemetryCommon other) : this() {
      timestamp_ = other.timestamp_;
      correlationVector_ = other.correlationVector_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TelemetryCommon Clone() {
      return new TelemetryCommon(this);
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 1;
    private long timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "correlation_vector" field.</summary>
    public const int CorrelationVectorFieldNumber = 2;
    private string correlationVector_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CorrelationVector {
      get { return correlationVector_; }
      set {
        correlationVector_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TelemetryCommon);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TelemetryCommon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Timestamp != other.Timestamp) return false;
      if (CorrelationVector != other.CorrelationVector) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Timestamp != 0L) hash ^= Timestamp.GetHashCode();
      if (CorrelationVector.Length != 0) hash ^= CorrelationVector.GetHashCode();
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
      if (Timestamp != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Timestamp);
      }
      if (CorrelationVector.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CorrelationVector);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Timestamp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Timestamp);
      }
      if (CorrelationVector.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CorrelationVector);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TelemetryCommon other) {
      if (other == null) {
        return;
      }
      if (other.Timestamp != 0L) {
        Timestamp = other.Timestamp;
      }
      if (other.CorrelationVector.Length != 0) {
        CorrelationVector = other.CorrelationVector;
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
          case 8: {
            Timestamp = input.ReadInt64();
            break;
          }
          case 18: {
            CorrelationVector = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
