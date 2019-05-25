// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/RedeemPoiPassCodeMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/RedeemPoiPassCodeMessage.proto</summary>
  public static partial class RedeemPoiPassCodeMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/RedeemPoiPassCodeMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RedeemPoiPassCodeMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1JlZGVl",
            "bVBvaVBhc3NDb2RlTWVzc2FnZS5wcm90bxIlV1VQcm90b3MuTmV0d29ya2lu",
            "Zy5SZXF1ZXN0cy5NZXNzYWdlcxojV1VQcm90b3MvRW51bXMvRGV2aWNlUGxh",
            "dGZvcm0ucHJvdG8iiAEKGFJlZGVlbVBvaVBhc3NDb2RlTWVzc2FnZRIQCghw",
            "YXNzY29kZRgBIAEoCRIQCghwb2lfZ3VpZBgCIAEoCRI3Cg9kZXZpY2VfcGxh",
            "dGZvcm0YAyABKA4yHi5XVVByb3Rvcy5FbnVtcy5EZXZpY2VQbGF0Zm9ybRIP",
            "CgdjYXJyaWVyGAQgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.DevicePlatformReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.RedeemPoiPassCodeMessage), global::WUProtos.Networking.Requests.Messages.RedeemPoiPassCodeMessage.Parser, new[]{ "Passcode", "PoiGuid", "DevicePlatform", "Carrier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RedeemPoiPassCodeMessage : pb::IMessage<RedeemPoiPassCodeMessage> {
    private static readonly pb::MessageParser<RedeemPoiPassCodeMessage> _parser = new pb::MessageParser<RedeemPoiPassCodeMessage>(() => new RedeemPoiPassCodeMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RedeemPoiPassCodeMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.RedeemPoiPassCodeMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPoiPassCodeMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPoiPassCodeMessage(RedeemPoiPassCodeMessage other) : this() {
      passcode_ = other.passcode_;
      poiGuid_ = other.poiGuid_;
      devicePlatform_ = other.devicePlatform_;
      carrier_ = other.carrier_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPoiPassCodeMessage Clone() {
      return new RedeemPoiPassCodeMessage(this);
    }

    /// <summary>Field number for the "passcode" field.</summary>
    public const int PasscodeFieldNumber = 1;
    private string passcode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Passcode {
      get { return passcode_; }
      set {
        passcode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "poi_guid" field.</summary>
    public const int PoiGuidFieldNumber = 2;
    private string poiGuid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PoiGuid {
      get { return poiGuid_; }
      set {
        poiGuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "device_platform" field.</summary>
    public const int DevicePlatformFieldNumber = 3;
    private global::WUProtos.Enums.DevicePlatform devicePlatform_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.DevicePlatform DevicePlatform {
      get { return devicePlatform_; }
      set {
        devicePlatform_ = value;
      }
    }

    /// <summary>Field number for the "carrier" field.</summary>
    public const int CarrierFieldNumber = 4;
    private string carrier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Carrier {
      get { return carrier_; }
      set {
        carrier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RedeemPoiPassCodeMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RedeemPoiPassCodeMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Passcode != other.Passcode) return false;
      if (PoiGuid != other.PoiGuid) return false;
      if (DevicePlatform != other.DevicePlatform) return false;
      if (Carrier != other.Carrier) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Passcode.Length != 0) hash ^= Passcode.GetHashCode();
      if (PoiGuid.Length != 0) hash ^= PoiGuid.GetHashCode();
      if (DevicePlatform != 0) hash ^= DevicePlatform.GetHashCode();
      if (Carrier.Length != 0) hash ^= Carrier.GetHashCode();
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
      if (Passcode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Passcode);
      }
      if (PoiGuid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PoiGuid);
      }
      if (DevicePlatform != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) DevicePlatform);
      }
      if (Carrier.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Carrier);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Passcode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Passcode);
      }
      if (PoiGuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PoiGuid);
      }
      if (DevicePlatform != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DevicePlatform);
      }
      if (Carrier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Carrier);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RedeemPoiPassCodeMessage other) {
      if (other == null) {
        return;
      }
      if (other.Passcode.Length != 0) {
        Passcode = other.Passcode;
      }
      if (other.PoiGuid.Length != 0) {
        PoiGuid = other.PoiGuid;
      }
      if (other.DevicePlatform != 0) {
        DevicePlatform = other.DevicePlatform;
      }
      if (other.Carrier.Length != 0) {
        Carrier = other.Carrier;
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
            Passcode = input.ReadString();
            break;
          }
          case 18: {
            PoiGuid = input.ReadString();
            break;
          }
          case 24: {
            DevicePlatform = (global::WUProtos.Enums.DevicePlatform) input.ReadEnum();
            break;
          }
          case 34: {
            Carrier = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code