// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/DbgResetStorePackPurchasedResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/DbgResetStorePackPurchasedResponse.proto</summary>
  public static partial class DbgResetStorePackPurchasedResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/DbgResetStorePackPurchasedResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DbgResetStorePackPurchasedResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9EYmdSZXNldFN0b3Jl",
            "UGFja1B1cmNoYXNlZFJlc3BvbnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3Jr",
            "aW5nLlJlc3BvbnNlcyI4CiJEYmdSZXNldFN0b3JlUGFja1B1cmNoYXNlZFJl",
            "c3BvbnNlEhIKCnN1Y2Nlc3NmdWwYASABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.DbgResetStorePackPurchasedResponse), global::WUProtos.Networking.Responses.DbgResetStorePackPurchasedResponse.Parser, new[]{ "Successful" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DbgResetStorePackPurchasedResponse : pb::IMessage<DbgResetStorePackPurchasedResponse> {
    private static readonly pb::MessageParser<DbgResetStorePackPurchasedResponse> _parser = new pb::MessageParser<DbgResetStorePackPurchasedResponse>(() => new DbgResetStorePackPurchasedResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DbgResetStorePackPurchasedResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.DbgResetStorePackPurchasedResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgResetStorePackPurchasedResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgResetStorePackPurchasedResponse(DbgResetStorePackPurchasedResponse other) : this() {
      successful_ = other.successful_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgResetStorePackPurchasedResponse Clone() {
      return new DbgResetStorePackPurchasedResponse(this);
    }

    /// <summary>Field number for the "successful" field.</summary>
    public const int SuccessfulFieldNumber = 1;
    private bool successful_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Successful {
      get { return successful_; }
      set {
        successful_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DbgResetStorePackPurchasedResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DbgResetStorePackPurchasedResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Successful != other.Successful) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Successful != false) hash ^= Successful.GetHashCode();
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
      if (Successful != false) {
        output.WriteRawTag(8);
        output.WriteBool(Successful);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Successful != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DbgResetStorePackPurchasedResponse other) {
      if (other == null) {
        return;
      }
      if (other.Successful != false) {
        Successful = other.Successful;
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
            Successful = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
