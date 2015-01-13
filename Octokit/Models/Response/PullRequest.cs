﻿using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class PullRequest
    {
        public PullRequest()
        {
        }

        public PullRequest(int number)
        {
            Number = number;
        }

        /// <summary>
        /// The URL for this pull request.
        /// </summary>
        public Uri Url { get; protected set; }

        /// <summary>
        /// The URL for the pull request page.
        /// </summary>
        public Uri HtmlUrl { get; protected set; }

        /// <summary>
        /// The URL for the pull request's diff (.diff) file.
        /// </summary>
        public Uri DiffUrl { get; protected set; }

        /// <summary>
        /// The URL for the pull request's patch (.patch) file.
        /// </summary>
        public Uri PatchUrl { get; protected set; }

        /// <summary>
        /// The URL for the specific pull request issue.
        /// </summary>
        public Uri IssueUrl { get; protected set; }

        /// <summary>
        /// The URL for the pull request statuses.
        /// </summary>
        public Uri StatusesUrl { get; protected set; }

        /// <summary>
        /// The pull request number.
        /// </summary>
        public int Number { get; protected set; }

        /// <summary>
        /// Whether the pull request is open or closed. The default is <see cref="ItemState.Open"/>.
        /// </summary>
        public ItemState State { get; protected set; }

        /// <summary>
        /// Title of the pull request.
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// The body (content) contained within the pull request.
        /// </summary>
        public string Body { get; protected set; }

        /// <summary>
        /// When the pull request was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; protected set; }

        /// <summary>
        /// When the pull request was last updated.
        /// </summary>
        public DateTimeOffset UpdatedAt { get; protected set; }

        /// <summary>
        /// When the pull request was closed.
        /// </summary>
        public DateTimeOffset? ClosedAt { get; protected set; }

        /// <summary>
        /// When the pull request was merged.
        /// </summary>
        public DateTimeOffset? MergedAt { get; protected set; }

        /// <summary>
        /// The HEAD reference for the pull request.
        /// </summary>
        public GitReference Head { get; protected set; }

        /// <summary>
        /// The BASE reference for the pull request.
        /// </summary>
        public GitReference Base { get; protected set; }

        /// <summary>
        /// The user who created the pull request.
        /// </summary>
        public User User { get; protected set; }

        /// <summary>
        /// The SHA of the merge commit.
        /// </summary>
        public string MergeCommitSha { get; protected set; }

        /// <summary>
        /// Whether or not the pull request has been merged.
        /// </summary>
        public bool Merged { get; protected set; }

        /// <summary>
        /// Whether or not the pull request can be merged.
        /// </summary>
        public bool? Mergeable { get; protected set; }

        /// <summary>
        /// The user who merged the pull request.
        /// </summary>
        public User MergedBy { get; protected set; }

        /// <summary>
        /// Total number of comments contained in the pull request.
        /// </summary>
        public int Comments { get; protected set; }

        /// <summary>
        /// Total number of commits contained in the pull request.
        /// </summary>
        public int Commits { get; protected set; }

        /// <summary>
        /// Total number of additions contained in the pull request.
        /// </summary>
        public int Additions { get; protected set; }

        /// <summary>
        /// Total number of deletions contained in the pull request.
        /// </summary>
        public int Deletions { get; protected set; }

        /// <summary>
        /// Total number of files changed in the pull request.
        /// </summary>
        public int ChangedFiles { get; protected set; }

        internal string DebuggerDisplay
        {
            get { return String.Format(CultureInfo.InvariantCulture, "Number: {0} State: {1}", Number, State); }
        }
    }
}
