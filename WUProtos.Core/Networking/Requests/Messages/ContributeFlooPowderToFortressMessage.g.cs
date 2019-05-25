// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/ContributeFlooPowderToFortressMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/ContributeFlooPowderToFortressMessage.proto</summary>
  public static partial class ContributeFlooPowderToFortressMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/ContributeFlooPowderToFortressMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContributeFlooPowderToFortressMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClFXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0NvbnRy",
            "aWJ1dGVGbG9vUG93ZGVyVG9Gb3J0cmVzc01lc3NhZ2UucHJvdG8SJVdVUHJv",
            "dG9zLk5ldHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMifQolQ29udHJpYnV0",
            "ZUZsb29Qb3dkZXJUb0ZvcnRyZXNzTWVzc2FnZRITCgtmb3J0cmVzc19pZBgB",
            "IAEoCRIUCgxmb3J0cmVzc19sYXQYAiABKAESFAoMZm9ydHJlc3NfbG5nGAMg",
            "ASgBEhMKC2Zsb29fcG93ZGVyGAQgASgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.ContributeFlooPowderToFortressMessage), global::WUProtos.Networking.Requests.Messages.ContributeFlooPowderToFortressMessage.Parser, new[]{ "FortressId", "FortressLat", "FortressLng", "FlooPowder" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ContributeFlooPowderToFortressMessage : pb::IMessage<ContributeFlooPowderToFortressMessage> {
    private static readonly pb::MessageParser<ContributeFlooPowderToFortressMessage> _parser = new pb::MessageParser<ContributeFlooPowderToFortressMessage>(() => new ContributeFlooPowderToFortressMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContributeFlooPowderToFortressMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.ContributeFlooPowderToFortressMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContributeFlooPowderToFortressMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContributeFlooPowderToFortressMessage(ContributeFlooPowderToFortressMessage other) : this() {
      fortressId_ = other.fortressId_;
      fortressLat_ = other.fortressLat_;
      fortressLng_ = other.fortressLng_;
      flooPowder_ = other.flooPowder_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContributeFlooPowderToFortressMessage Clone() {
      return new ContributeFlooPowderToFortressMessage(this);
    }

    /// <summary>Field number for the "fortress_id" field.</summary>
    public const int FortressIdFieldNumber = 1;
    private string fortressId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortressId {
      get { return fortressId_; }
      set {
        fortressId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fortress_lat" field.</summary>
    public const int FortressLatFieldNumber = 2;
    private double fortressLat_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double FortressLat {
      get { return fortressLat_; }
      set {
        fortressLat_ = value;
      }
    }

    /// <summary>Field number for the "fortress_lng" field.</summary>
    public const int FortressLngFieldNumber = 3;
    private double fortressLng_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double FortressLng {
      get { return fortressLng_; }
      set {
        fortressLng_ = value;
      }
    }

    /// <summary>Field number for the "floo_powder" field.</summary>
    public const int FlooPowderFieldNumber = 4;
    private long flooPowder_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long FlooPowder {
      get { return flooPowder_; }
      set {
        flooPowder_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContributeFlooPowderToFortressMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContributeFlooPowderToFortressMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FortressId != other.FortressId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FortressLat, other.FortressLat)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FortressLng, other.FortressLng)) return false;
      if (FlooPowder != other.FlooPowder) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FortressId.Length != 0) hash ^= FortressId.GetHashCode();
      if (FortressLat != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FortressLat);
      if (FortressLng != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FortressLng);
      if (FlooPowder != 0L) hash ^= FlooPowder.GetHashCode();
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
      if (FortressId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FortressId);
      }
      if (FortressLat != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(FortressLat);
      }
      if (FortressLng != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(FortressLng);
      }
      if (FlooPowder != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(FlooPowder);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FortressId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortressId);
      }
      if (FortressLat != 0D) {
        size += 1 + 8;
      }
      if (FortressLng != 0D) {
        size += 1 + 8;
      }
      if (FlooPowder != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FlooPowder);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContributeFlooPowderToFortressMessage other) {
      if (other == null) {
        return;
      }
      if (other.FortressId.Length != 0) {
        FortressId = other.FortressId;
      }
      if (other.FortressLat != 0D) {
        FortressLat = other.FortressLat;
      }
      if (other.FortressLng != 0D) {
        FortressLng = other.FortressLng;
      }
      if (other.FlooPowder != 0L) {
        FlooPowder = other.FlooPowder;
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
            FortressId = input.ReadString();
            break;
          }
          case 17: {
            FortressLat = input.ReadDouble();
            break;
          }
          case 25: {
            FortressLng = input.ReadDouble();
            break;
          }
          case 32: {
            FlooPowder = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
