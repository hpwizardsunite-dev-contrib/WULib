// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/EncounterGetStateMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/EncounterGetStateMessage.proto</summary>
  public static partial class EncounterGetStateMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/EncounterGetStateMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterGetStateMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0VuY291",
            "bnRlckdldFN0YXRlTWVzc2FnZS5wcm90bxIlV1VQcm90b3MuTmV0d29ya2lu",
            "Zy5SZXF1ZXN0cy5NZXNzYWdlcyIwChhFbmNvdW50ZXJHZXRTdGF0ZU1lc3Nh",
            "Z2USFAoMZW5jb3VudGVyX2lkGAEgASgMYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.EncounterGetStateMessage), global::WUProtos.Networking.Requests.Messages.EncounterGetStateMessage.Parser, new[]{ "EncounterId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterGetStateMessage : pb::IMessage<EncounterGetStateMessage> {
    private static readonly pb::MessageParser<EncounterGetStateMessage> _parser = new pb::MessageParser<EncounterGetStateMessage>(() => new EncounterGetStateMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterGetStateMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.EncounterGetStateMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterGetStateMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterGetStateMessage(EncounterGetStateMessage other) : this() {
      encounterId_ = other.encounterId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterGetStateMessage Clone() {
      return new EncounterGetStateMessage(this);
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 1;
    private pb::ByteString encounterId_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncounterGetStateMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterGetStateMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncounterId != other.EncounterId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncounterId.Length != 0) hash ^= EncounterId.GetHashCode();
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
      if (EncounterId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(EncounterId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncounterId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(EncounterId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterGetStateMessage other) {
      if (other == null) {
        return;
      }
      if (other.EncounterId.Length != 0) {
        EncounterId = other.EncounterId;
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
            EncounterId = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code