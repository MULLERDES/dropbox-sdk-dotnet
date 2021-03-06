// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The shared link access failure reason object</para>
    /// </summary>
    public class SharedLinkAccessFailureReason
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedLinkAccessFailureReason> Encoder = new SharedLinkAccessFailureReasonEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedLinkAccessFailureReason> Decoder = new SharedLinkAccessFailureReasonDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedLinkAccessFailureReason"
        /// /> class.</para>
        /// </summary>
        public SharedLinkAccessFailureReason()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is LoginRequired</para>
        /// </summary>
        public bool IsLoginRequired
        {
            get
            {
                return this is LoginRequired;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a LoginRequired, or <c>null</c>.</para>
        /// </summary>
        public LoginRequired AsLoginRequired
        {
            get
            {
                return this as LoginRequired;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is EmailVerifyRequired</para>
        /// </summary>
        public bool IsEmailVerifyRequired
        {
            get
            {
                return this is EmailVerifyRequired;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a EmailVerifyRequired, or <c>null</c>.</para>
        /// </summary>
        public EmailVerifyRequired AsEmailVerifyRequired
        {
            get
            {
                return this as EmailVerifyRequired;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PasswordRequired</para>
        /// </summary>
        public bool IsPasswordRequired
        {
            get
            {
                return this is PasswordRequired;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PasswordRequired, or <c>null</c>.</para>
        /// </summary>
        public PasswordRequired AsPasswordRequired
        {
            get
            {
                return this as PasswordRequired;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TeamOnly</para>
        /// </summary>
        public bool IsTeamOnly
        {
            get
            {
                return this is TeamOnly;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TeamOnly, or <c>null</c>.</para>
        /// </summary>
        public TeamOnly AsTeamOnly
        {
            get
            {
                return this as TeamOnly;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is OwnerOnly</para>
        /// </summary>
        public bool IsOwnerOnly
        {
            get
            {
                return this is OwnerOnly;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a OwnerOnly, or <c>null</c>.</para>
        /// </summary>
        public OwnerOnly AsOwnerOnly
        {
            get
            {
                return this as OwnerOnly;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedLinkAccessFailureReason" />.</para>
        /// </summary>
        private class SharedLinkAccessFailureReasonEncoder : enc.StructEncoder<SharedLinkAccessFailureReason>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedLinkAccessFailureReason value, enc.IJsonWriter writer)
            {
                if (value is LoginRequired)
                {
                    WriteProperty(".tag", "login_required", writer, enc.StringEncoder.Instance);
                    LoginRequired.Encoder.EncodeFields((LoginRequired)value, writer);
                    return;
                }
                if (value is EmailVerifyRequired)
                {
                    WriteProperty(".tag", "email_verify_required", writer, enc.StringEncoder.Instance);
                    EmailVerifyRequired.Encoder.EncodeFields((EmailVerifyRequired)value, writer);
                    return;
                }
                if (value is PasswordRequired)
                {
                    WriteProperty(".tag", "password_required", writer, enc.StringEncoder.Instance);
                    PasswordRequired.Encoder.EncodeFields((PasswordRequired)value, writer);
                    return;
                }
                if (value is TeamOnly)
                {
                    WriteProperty(".tag", "team_only", writer, enc.StringEncoder.Instance);
                    TeamOnly.Encoder.EncodeFields((TeamOnly)value, writer);
                    return;
                }
                if (value is OwnerOnly)
                {
                    WriteProperty(".tag", "owner_only", writer, enc.StringEncoder.Instance);
                    OwnerOnly.Encoder.EncodeFields((OwnerOnly)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedLinkAccessFailureReason" />.</para>
        /// </summary>
        private class SharedLinkAccessFailureReasonDecoder : enc.UnionDecoder<SharedLinkAccessFailureReason>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedLinkAccessFailureReason"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedLinkAccessFailureReason Create()
            {
                return new SharedLinkAccessFailureReason();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SharedLinkAccessFailureReason Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "login_required":
                        return LoginRequired.Decoder.DecodeFields(reader);
                    case "email_verify_required":
                        return EmailVerifyRequired.Decoder.DecodeFields(reader);
                    case "password_required":
                        return PasswordRequired.Decoder.DecodeFields(reader);
                    case "team_only":
                        return TeamOnly.Decoder.DecodeFields(reader);
                    case "owner_only":
                        return OwnerOnly.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>User is not logged in.</para>
        /// </summary>
        public sealed class LoginRequired : SharedLinkAccessFailureReason
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<LoginRequired> Encoder = new LoginRequiredEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<LoginRequired> Decoder = new LoginRequiredDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="LoginRequired" />
            /// class.</para>
            /// </summary>
            private LoginRequired()
            {
            }

            /// <summary>
            /// <para>A singleton instance of LoginRequired</para>
            /// </summary>
            public static readonly LoginRequired Instance = new LoginRequired();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="LoginRequired" />.</para>
            /// </summary>
            private class LoginRequiredEncoder : enc.StructEncoder<LoginRequired>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(LoginRequired value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="LoginRequired" />.</para>
            /// </summary>
            private class LoginRequiredDecoder : enc.StructDecoder<LoginRequired>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="LoginRequired" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override LoginRequired Create()
                {
                    return new LoginRequired();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override LoginRequired DecodeFields(enc.IJsonReader reader)
                {
                    return LoginRequired.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>User's email is not verified.</para>
        /// </summary>
        public sealed class EmailVerifyRequired : SharedLinkAccessFailureReason
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<EmailVerifyRequired> Encoder = new EmailVerifyRequiredEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<EmailVerifyRequired> Decoder = new EmailVerifyRequiredDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="EmailVerifyRequired" />
            /// class.</para>
            /// </summary>
            private EmailVerifyRequired()
            {
            }

            /// <summary>
            /// <para>A singleton instance of EmailVerifyRequired</para>
            /// </summary>
            public static readonly EmailVerifyRequired Instance = new EmailVerifyRequired();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="EmailVerifyRequired" />.</para>
            /// </summary>
            private class EmailVerifyRequiredEncoder : enc.StructEncoder<EmailVerifyRequired>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(EmailVerifyRequired value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="EmailVerifyRequired" />.</para>
            /// </summary>
            private class EmailVerifyRequiredDecoder : enc.StructDecoder<EmailVerifyRequired>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="EmailVerifyRequired"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override EmailVerifyRequired Create()
                {
                    return new EmailVerifyRequired();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override EmailVerifyRequired DecodeFields(enc.IJsonReader reader)
                {
                    return EmailVerifyRequired.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The link is password protected.</para>
        /// </summary>
        public sealed class PasswordRequired : SharedLinkAccessFailureReason
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PasswordRequired> Encoder = new PasswordRequiredEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PasswordRequired> Decoder = new PasswordRequiredDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PasswordRequired" />
            /// class.</para>
            /// </summary>
            private PasswordRequired()
            {
            }

            /// <summary>
            /// <para>A singleton instance of PasswordRequired</para>
            /// </summary>
            public static readonly PasswordRequired Instance = new PasswordRequired();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PasswordRequired" />.</para>
            /// </summary>
            private class PasswordRequiredEncoder : enc.StructEncoder<PasswordRequired>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PasswordRequired value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PasswordRequired" />.</para>
            /// </summary>
            private class PasswordRequiredDecoder : enc.StructDecoder<PasswordRequired>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PasswordRequired" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PasswordRequired Create()
                {
                    return new PasswordRequired();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override PasswordRequired DecodeFields(enc.IJsonReader reader)
                {
                    return PasswordRequired.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Access is allowed for team members only.</para>
        /// </summary>
        public sealed class TeamOnly : SharedLinkAccessFailureReason
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TeamOnly> Encoder = new TeamOnlyEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TeamOnly> Decoder = new TeamOnlyDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TeamOnly" /> class.</para>
            /// </summary>
            private TeamOnly()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TeamOnly</para>
            /// </summary>
            public static readonly TeamOnly Instance = new TeamOnly();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TeamOnly" />.</para>
            /// </summary>
            private class TeamOnlyEncoder : enc.StructEncoder<TeamOnly>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TeamOnly value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TeamOnly" />.</para>
            /// </summary>
            private class TeamOnlyDecoder : enc.StructDecoder<TeamOnly>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TeamOnly" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TeamOnly Create()
                {
                    return new TeamOnly();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override TeamOnly DecodeFields(enc.IJsonReader reader)
                {
                    return TeamOnly.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Access is allowed for the shared link's owner only.</para>
        /// </summary>
        public sealed class OwnerOnly : SharedLinkAccessFailureReason
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<OwnerOnly> Encoder = new OwnerOnlyEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<OwnerOnly> Decoder = new OwnerOnlyDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="OwnerOnly" /> class.</para>
            /// </summary>
            private OwnerOnly()
            {
            }

            /// <summary>
            /// <para>A singleton instance of OwnerOnly</para>
            /// </summary>
            public static readonly OwnerOnly Instance = new OwnerOnly();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="OwnerOnly" />.</para>
            /// </summary>
            private class OwnerOnlyEncoder : enc.StructEncoder<OwnerOnly>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(OwnerOnly value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="OwnerOnly" />.</para>
            /// </summary>
            private class OwnerOnlyDecoder : enc.StructDecoder<OwnerOnly>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="OwnerOnly" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override OwnerOnly Create()
                {
                    return new OwnerOnly();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override OwnerOnly DecodeFields(enc.IJsonReader reader)
                {
                    return OwnerOnly.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>An unknown accessibility failure.</para>
        /// </summary>
        public sealed class Other : SharedLinkAccessFailureReason
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
