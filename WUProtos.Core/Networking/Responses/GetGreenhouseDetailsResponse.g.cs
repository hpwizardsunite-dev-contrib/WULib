// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/GetGreenhouseDetailsResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/GetGreenhouseDetailsResponse.proto</summary>
  public static partial class GetGreenhouseDetailsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/GetGreenhouseDetailsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetGreenhouseDetailsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9HZXRHcmVlbmhvdXNl",
            "RGV0YWlsc1Jlc3BvbnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLlJl",
            "c3BvbnNlcxoeV1VQcm90b3MvRGF0YS9Qb2lEZXRhaWxzLnByb3RvGiVXVVBy",
            "b3Rvcy9FbnVtcy9Qb2lBY2Nlc3NpYmlsaXR5LnByb3RvIrQFChxHZXRHcmVl",
            "bmhvdXNlRGV0YWlsc1Jlc3BvbnNlEhIKCnBhcnRuZXJfaWQYASABKAkSLgoL",
            "cG9pX2RldGFpbHMYAiABKAsyGS5XVVByb3Rvcy5EYXRhLlBvaURldGFpbHMS",
            "OwoRcG9pX2FjY2Vzc2liaWxpdHkYAyABKA4yIC5XVVByb3Rvcy5FbnVtcy5Q",
            "b2lBY2Nlc3NpYmlsaXR5ElkKCm5vcm1hbF9wb3QYBCADKAsyRS5XVVByb3Rv",
            "cy5OZXR3b3JraW5nLlJlc3BvbnNlcy5HZXRHcmVlbmhvdXNlRGV0YWlsc1Jl",
            "c3BvbnNlLkNsaWVudFBvdBJZCgpyZW50YWxfcG90GAUgAygLMkUuV1VQcm90",
            "b3MuTmV0d29ya2luZy5SZXNwb25zZXMuR2V0R3JlZW5ob3VzZURldGFpbHNS",
            "ZXNwb25zZS5DbGllbnRQb3Qa3AIKCUNsaWVudFBvdBIKCgJpZBgBIAEoCRIV",
            "Cg1yZWNpcGVfZ210X2lkGAIgASgJEg8KB3BsYW50ZXIYAyABKAkSEwoLY29u",
            "dHJpYnV0b3IYBCADKAkSIgoaZ3Jvd2luZ19jb21wbGV0aW9uX3RpbWVfbXMY",
            "BSABKAMSEwoLc3BlbGxfY291bnQYBiABKAUSawoOcmVudGFsX2RldGFpbHMY",
            "ByABKAsyUy5XVVByb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5HZXRHcmVl",
            "bmhvdXNlRGV0YWlsc1Jlc3BvbnNlLkNsaWVudFBvdC5SZW50YWxEZXRhaWxz",
            "GmAKDVJlbnRhbERldGFpbHMSDgoGcmVudGVyGAEgASgJEhwKFHJlbnRhbF9z",
            "dGFydF90aW1lX21zGAIgASgDEiEKGXJlbnRhbF9leHBpcmF0aW9uX3RpbWVf",
            "bXMYAyABKANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.PoiDetailsReflection.Descriptor, global::WUProtos.Enums.PoiAccessibilityReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse), global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Parser, new[]{ "PartnerId", "PoiDetails", "PoiAccessibility", "NormalPot", "RentalPot" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot), global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot.Parser, new[]{ "Id", "RecipeGmtId", "Planter", "Contributor", "GrowingCompletionTimeMs", "SpellCount", "RentalDetails" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot.Types.RentalDetails), global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot.Types.RentalDetails.Parser, new[]{ "Renter", "RentalStartTimeMs", "RentalExpirationTimeMs" }, null, null, null)})})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetGreenhouseDetailsResponse : pb::IMessage<GetGreenhouseDetailsResponse> {
    private static readonly pb::MessageParser<GetGreenhouseDetailsResponse> _parser = new pb::MessageParser<GetGreenhouseDetailsResponse>(() => new GetGreenhouseDetailsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetGreenhouseDetailsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGreenhouseDetailsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGreenhouseDetailsResponse(GetGreenhouseDetailsResponse other) : this() {
      partnerId_ = other.partnerId_;
      poiDetails_ = other.poiDetails_ != null ? other.poiDetails_.Clone() : null;
      poiAccessibility_ = other.poiAccessibility_;
      normalPot_ = other.normalPot_.Clone();
      rentalPot_ = other.rentalPot_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGreenhouseDetailsResponse Clone() {
      return new GetGreenhouseDetailsResponse(this);
    }

    /// <summary>Field number for the "partner_id" field.</summary>
    public const int PartnerIdFieldNumber = 1;
    private string partnerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PartnerId {
      get { return partnerId_; }
      set {
        partnerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "poi_details" field.</summary>
    public const int PoiDetailsFieldNumber = 2;
    private global::WUProtos.Data.PoiDetails poiDetails_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.PoiDetails PoiDetails {
      get { return poiDetails_; }
      set {
        poiDetails_ = value;
      }
    }

    /// <summary>Field number for the "poi_accessibility" field.</summary>
    public const int PoiAccessibilityFieldNumber = 3;
    private global::WUProtos.Enums.PoiAccessibility poiAccessibility_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.PoiAccessibility PoiAccessibility {
      get { return poiAccessibility_; }
      set {
        poiAccessibility_ = value;
      }
    }

    /// <summary>Field number for the "normal_pot" field.</summary>
    public const int NormalPotFieldNumber = 4;
    private static readonly pb::FieldCodec<global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot> _repeated_normalPot_codec
        = pb::FieldCodec.ForMessage(34, global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot> normalPot_ = new pbc::RepeatedField<global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot> NormalPot {
      get { return normalPot_; }
    }

    /// <summary>Field number for the "rental_pot" field.</summary>
    public const int RentalPotFieldNumber = 5;
    private static readonly pb::FieldCodec<global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot> _repeated_rentalPot_codec
        = pb::FieldCodec.ForMessage(42, global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot> rentalPot_ = new pbc::RepeatedField<global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot> RentalPot {
      get { return rentalPot_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetGreenhouseDetailsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetGreenhouseDetailsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PartnerId != other.PartnerId) return false;
      if (!object.Equals(PoiDetails, other.PoiDetails)) return false;
      if (PoiAccessibility != other.PoiAccessibility) return false;
      if(!normalPot_.Equals(other.normalPot_)) return false;
      if(!rentalPot_.Equals(other.rentalPot_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PartnerId.Length != 0) hash ^= PartnerId.GetHashCode();
      if (poiDetails_ != null) hash ^= PoiDetails.GetHashCode();
      if (PoiAccessibility != 0) hash ^= PoiAccessibility.GetHashCode();
      hash ^= normalPot_.GetHashCode();
      hash ^= rentalPot_.GetHashCode();
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
      if (PartnerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PartnerId);
      }
      if (poiDetails_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PoiDetails);
      }
      if (PoiAccessibility != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) PoiAccessibility);
      }
      normalPot_.WriteTo(output, _repeated_normalPot_codec);
      rentalPot_.WriteTo(output, _repeated_rentalPot_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PartnerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PartnerId);
      }
      if (poiDetails_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PoiDetails);
      }
      if (PoiAccessibility != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PoiAccessibility);
      }
      size += normalPot_.CalculateSize(_repeated_normalPot_codec);
      size += rentalPot_.CalculateSize(_repeated_rentalPot_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetGreenhouseDetailsResponse other) {
      if (other == null) {
        return;
      }
      if (other.PartnerId.Length != 0) {
        PartnerId = other.PartnerId;
      }
      if (other.poiDetails_ != null) {
        if (poiDetails_ == null) {
          PoiDetails = new global::WUProtos.Data.PoiDetails();
        }
        PoiDetails.MergeFrom(other.PoiDetails);
      }
      if (other.PoiAccessibility != 0) {
        PoiAccessibility = other.PoiAccessibility;
      }
      normalPot_.Add(other.normalPot_);
      rentalPot_.Add(other.rentalPot_);
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
            PartnerId = input.ReadString();
            break;
          }
          case 18: {
            if (poiDetails_ == null) {
              PoiDetails = new global::WUProtos.Data.PoiDetails();
            }
            input.ReadMessage(PoiDetails);
            break;
          }
          case 24: {
            PoiAccessibility = (global::WUProtos.Enums.PoiAccessibility) input.ReadEnum();
            break;
          }
          case 34: {
            normalPot_.AddEntriesFrom(input, _repeated_normalPot_codec);
            break;
          }
          case 42: {
            rentalPot_.AddEntriesFrom(input, _repeated_rentalPot_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GetGreenhouseDetailsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class ClientPot : pb::IMessage<ClientPot> {
        private static readonly pb::MessageParser<ClientPot> _parser = new pb::MessageParser<ClientPot>(() => new ClientPot());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ClientPot> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ClientPot() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ClientPot(ClientPot other) : this() {
          id_ = other.id_;
          recipeGmtId_ = other.recipeGmtId_;
          planter_ = other.planter_;
          contributor_ = other.contributor_.Clone();
          growingCompletionTimeMs_ = other.growingCompletionTimeMs_;
          spellCount_ = other.spellCount_;
          rentalDetails_ = other.rentalDetails_ != null ? other.rentalDetails_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ClientPot Clone() {
          return new ClientPot(this);
        }

        /// <summary>Field number for the "id" field.</summary>
        public const int IdFieldNumber = 1;
        private string id_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Id {
          get { return id_; }
          set {
            id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "recipe_gmt_id" field.</summary>
        public const int RecipeGmtIdFieldNumber = 2;
        private string recipeGmtId_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string RecipeGmtId {
          get { return recipeGmtId_; }
          set {
            recipeGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "planter" field.</summary>
        public const int PlanterFieldNumber = 3;
        private string planter_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Planter {
          get { return planter_; }
          set {
            planter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "contributor" field.</summary>
        public const int ContributorFieldNumber = 4;
        private static readonly pb::FieldCodec<string> _repeated_contributor_codec
            = pb::FieldCodec.ForString(34);
        private readonly pbc::RepeatedField<string> contributor_ = new pbc::RepeatedField<string>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<string> Contributor {
          get { return contributor_; }
        }

        /// <summary>Field number for the "growing_completion_time_ms" field.</summary>
        public const int GrowingCompletionTimeMsFieldNumber = 5;
        private long growingCompletionTimeMs_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long GrowingCompletionTimeMs {
          get { return growingCompletionTimeMs_; }
          set {
            growingCompletionTimeMs_ = value;
          }
        }

        /// <summary>Field number for the "spell_count" field.</summary>
        public const int SpellCountFieldNumber = 6;
        private int spellCount_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int SpellCount {
          get { return spellCount_; }
          set {
            spellCount_ = value;
          }
        }

        /// <summary>Field number for the "rental_details" field.</summary>
        public const int RentalDetailsFieldNumber = 7;
        private global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot.Types.RentalDetails rentalDetails_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot.Types.RentalDetails RentalDetails {
          get { return rentalDetails_; }
          set {
            rentalDetails_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ClientPot);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ClientPot other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Id != other.Id) return false;
          if (RecipeGmtId != other.RecipeGmtId) return false;
          if (Planter != other.Planter) return false;
          if(!contributor_.Equals(other.contributor_)) return false;
          if (GrowingCompletionTimeMs != other.GrowingCompletionTimeMs) return false;
          if (SpellCount != other.SpellCount) return false;
          if (!object.Equals(RentalDetails, other.RentalDetails)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Id.Length != 0) hash ^= Id.GetHashCode();
          if (RecipeGmtId.Length != 0) hash ^= RecipeGmtId.GetHashCode();
          if (Planter.Length != 0) hash ^= Planter.GetHashCode();
          hash ^= contributor_.GetHashCode();
          if (GrowingCompletionTimeMs != 0L) hash ^= GrowingCompletionTimeMs.GetHashCode();
          if (SpellCount != 0) hash ^= SpellCount.GetHashCode();
          if (rentalDetails_ != null) hash ^= RentalDetails.GetHashCode();
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
          if (Id.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Id);
          }
          if (RecipeGmtId.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(RecipeGmtId);
          }
          if (Planter.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Planter);
          }
          contributor_.WriteTo(output, _repeated_contributor_codec);
          if (GrowingCompletionTimeMs != 0L) {
            output.WriteRawTag(40);
            output.WriteInt64(GrowingCompletionTimeMs);
          }
          if (SpellCount != 0) {
            output.WriteRawTag(48);
            output.WriteInt32(SpellCount);
          }
          if (rentalDetails_ != null) {
            output.WriteRawTag(58);
            output.WriteMessage(RentalDetails);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Id.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
          }
          if (RecipeGmtId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(RecipeGmtId);
          }
          if (Planter.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Planter);
          }
          size += contributor_.CalculateSize(_repeated_contributor_codec);
          if (GrowingCompletionTimeMs != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(GrowingCompletionTimeMs);
          }
          if (SpellCount != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(SpellCount);
          }
          if (rentalDetails_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(RentalDetails);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ClientPot other) {
          if (other == null) {
            return;
          }
          if (other.Id.Length != 0) {
            Id = other.Id;
          }
          if (other.RecipeGmtId.Length != 0) {
            RecipeGmtId = other.RecipeGmtId;
          }
          if (other.Planter.Length != 0) {
            Planter = other.Planter;
          }
          contributor_.Add(other.contributor_);
          if (other.GrowingCompletionTimeMs != 0L) {
            GrowingCompletionTimeMs = other.GrowingCompletionTimeMs;
          }
          if (other.SpellCount != 0) {
            SpellCount = other.SpellCount;
          }
          if (other.rentalDetails_ != null) {
            if (rentalDetails_ == null) {
              RentalDetails = new global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot.Types.RentalDetails();
            }
            RentalDetails.MergeFrom(other.RentalDetails);
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
                Id = input.ReadString();
                break;
              }
              case 18: {
                RecipeGmtId = input.ReadString();
                break;
              }
              case 26: {
                Planter = input.ReadString();
                break;
              }
              case 34: {
                contributor_.AddEntriesFrom(input, _repeated_contributor_codec);
                break;
              }
              case 40: {
                GrowingCompletionTimeMs = input.ReadInt64();
                break;
              }
              case 48: {
                SpellCount = input.ReadInt32();
                break;
              }
              case 58: {
                if (rentalDetails_ == null) {
                  RentalDetails = new global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot.Types.RentalDetails();
                }
                input.ReadMessage(RentalDetails);
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the ClientPot message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          public sealed partial class RentalDetails : pb::IMessage<RentalDetails> {
            private static readonly pb::MessageParser<RentalDetails> _parser = new pb::MessageParser<RentalDetails>(() => new RentalDetails());
            private pb::UnknownFieldSet _unknownFields;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pb::MessageParser<RentalDetails> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Types.ClientPot.Descriptor.NestedTypes[0]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public RentalDetails() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public RentalDetails(RentalDetails other) : this() {
              renter_ = other.renter_;
              rentalStartTimeMs_ = other.rentalStartTimeMs_;
              rentalExpirationTimeMs_ = other.rentalExpirationTimeMs_;
              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public RentalDetails Clone() {
              return new RentalDetails(this);
            }

            /// <summary>Field number for the "renter" field.</summary>
            public const int RenterFieldNumber = 1;
            private string renter_ = "";
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public string Renter {
              get { return renter_; }
              set {
                renter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
              }
            }

            /// <summary>Field number for the "rental_start_time_ms" field.</summary>
            public const int RentalStartTimeMsFieldNumber = 2;
            private long rentalStartTimeMs_;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public long RentalStartTimeMs {
              get { return rentalStartTimeMs_; }
              set {
                rentalStartTimeMs_ = value;
              }
            }

            /// <summary>Field number for the "rental_expiration_time_ms" field.</summary>
            public const int RentalExpirationTimeMsFieldNumber = 3;
            private long rentalExpirationTimeMs_;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public long RentalExpirationTimeMs {
              get { return rentalExpirationTimeMs_; }
              set {
                rentalExpirationTimeMs_ = value;
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override bool Equals(object other) {
              return Equals(other as RentalDetails);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public bool Equals(RentalDetails other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (Renter != other.Renter) return false;
              if (RentalStartTimeMs != other.RentalStartTimeMs) return false;
              if (RentalExpirationTimeMs != other.RentalExpirationTimeMs) return false;
              return Equals(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override int GetHashCode() {
              int hash = 1;
              if (Renter.Length != 0) hash ^= Renter.GetHashCode();
              if (RentalStartTimeMs != 0L) hash ^= RentalStartTimeMs.GetHashCode();
              if (RentalExpirationTimeMs != 0L) hash ^= RentalExpirationTimeMs.GetHashCode();
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
              if (Renter.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(Renter);
              }
              if (RentalStartTimeMs != 0L) {
                output.WriteRawTag(16);
                output.WriteInt64(RentalStartTimeMs);
              }
              if (RentalExpirationTimeMs != 0L) {
                output.WriteRawTag(24);
                output.WriteInt64(RentalExpirationTimeMs);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int CalculateSize() {
              int size = 0;
              if (Renter.Length != 0) {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Renter);
              }
              if (RentalStartTimeMs != 0L) {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(RentalStartTimeMs);
              }
              if (RentalExpirationTimeMs != 0L) {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(RentalExpirationTimeMs);
              }
              if (_unknownFields != null) {
                size += _unknownFields.CalculateSize();
              }
              return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(RentalDetails other) {
              if (other == null) {
                return;
              }
              if (other.Renter.Length != 0) {
                Renter = other.Renter;
              }
              if (other.RentalStartTimeMs != 0L) {
                RentalStartTimeMs = other.RentalStartTimeMs;
              }
              if (other.RentalExpirationTimeMs != 0L) {
                RentalExpirationTimeMs = other.RentalExpirationTimeMs;
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
                    Renter = input.ReadString();
                    break;
                  }
                  case 16: {
                    RentalStartTimeMs = input.ReadInt64();
                    break;
                  }
                  case 24: {
                    RentalExpirationTimeMs = input.ReadInt64();
                    break;
                  }
                }
              }
            }

          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code