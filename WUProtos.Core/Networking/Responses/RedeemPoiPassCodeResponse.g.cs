// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/RedeemPoiPassCodeResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/RedeemPoiPassCodeResponse.proto</summary>
  public static partial class RedeemPoiPassCodeResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/RedeemPoiPassCodeResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RedeemPoiPassCodeResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1XVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9SZWRlZW1Qb2lQYXNz",
            "Q29kZVJlc3BvbnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
            "bnNlcxojV1VQcm90b3MvRGF0YS9Mb290L0xvb3RSZXdhcmQucHJvdG8iyAIK",
            "GVJlZGVlbVBvaVBhc3NDb2RlUmVzcG9uc2USTwoGc3RhdHVzGAEgASgOMj8u",
            "V1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuUmVkZWVtUG9pUGFzc0Nv",
            "ZGVSZXNwb25zZS5TdGF0dXMSPgoHcmV3YXJkcxgCIAEoCzItLldVUHJvdG9z",
            "LkRhdGEuTG9vdC5Mb290UmV3YXJkLkxvb3RDb2xsZWN0aW9uIpkBCgZTdGF0",
            "dXMSCwoHVU5LTk9XThAAEgsKB1NVQ0NFU1MQARIUChBBTFJFQURZX1JFREVF",
            "TUVEEAISGgoWRkFJTEVEX0lOVkVOVE9SWV9DSEVDSxADEhAKDE9VVF9PRl9S",
            "QU5HRRAEEhIKDldST05HX0xPQ0FUSU9OEAUSEAoMUkFURV9MSU1JVEVEEAYS",
            "CwoHSU5WQUxJRBAHYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootRewardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.RedeemPoiPassCodeResponse), global::WUProtos.Networking.Responses.RedeemPoiPassCodeResponse.Parser, new[]{ "Status", "Rewards" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.RedeemPoiPassCodeResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RedeemPoiPassCodeResponse : pb::IMessage<RedeemPoiPassCodeResponse> {
    private static readonly pb::MessageParser<RedeemPoiPassCodeResponse> _parser = new pb::MessageParser<RedeemPoiPassCodeResponse>(() => new RedeemPoiPassCodeResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RedeemPoiPassCodeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.RedeemPoiPassCodeResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPoiPassCodeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPoiPassCodeResponse(RedeemPoiPassCodeResponse other) : this() {
      status_ = other.status_;
      rewards_ = other.rewards_ != null ? other.rewards_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPoiPassCodeResponse Clone() {
      return new RedeemPoiPassCodeResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Networking.Responses.RedeemPoiPassCodeResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.RedeemPoiPassCodeResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "rewards" field.</summary>
    public const int RewardsFieldNumber = 2;
    private global::WUProtos.Data.Loot.LootReward.Types.LootCollection rewards_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootReward.Types.LootCollection Rewards {
      get { return rewards_; }
      set {
        rewards_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RedeemPoiPassCodeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RedeemPoiPassCodeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(Rewards, other.Rewards)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (rewards_ != null) hash ^= Rewards.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (rewards_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Rewards);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (rewards_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rewards);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RedeemPoiPassCodeResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.rewards_ != null) {
        if (rewards_ == null) {
          Rewards = new global::WUProtos.Data.Loot.LootReward.Types.LootCollection();
        }
        Rewards.MergeFrom(other.Rewards);
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
            Status = (global::WUProtos.Networking.Responses.RedeemPoiPassCodeResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (rewards_ == null) {
              Rewards = new global::WUProtos.Data.Loot.LootReward.Types.LootCollection();
            }
            input.ReadMessage(Rewards);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RedeemPoiPassCodeResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ALREADY_REDEEMED")] AlreadyRedeemed = 2,
        [pbr::OriginalName("FAILED_INVENTORY_CHECK")] FailedInventoryCheck = 3,
        [pbr::OriginalName("OUT_OF_RANGE")] OutOfRange = 4,
        [pbr::OriginalName("WRONG_LOCATION")] WrongLocation = 5,
        [pbr::OriginalName("RATE_LIMITED")] RateLimited = 6,
        [pbr::OriginalName("INVALID")] Invalid = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code