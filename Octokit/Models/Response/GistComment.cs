﻿using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class GistComment
    {
        /// <summary>
        /// The gist comment id.
        /// </summary>
        public int Id { get; protected set; }

        /// <summary>
        /// The URL for this gist comment.
        /// </summary>
        public Uri Url { get; protected set; }

        /// <summary>
        /// The body of this gist comment.
        /// </summary>t
        public string Body { get; protected set; }

        /// <summary>
        /// The user that created this gist comment.
        /// </summary>
        public User User { get; protected set; }

        /// <summary>
        /// The date this comment was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; protected set; }

        /// <summary>
        /// The date this comment was last updated.
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; protected set; }

        internal string DebuggerDisplay
        {
            get
            {
                return String.Format(CultureInfo.InvariantCulture, "Id: {0} CreatedAt: {1}", Id, CreatedAt);
            }
        }
    }
}