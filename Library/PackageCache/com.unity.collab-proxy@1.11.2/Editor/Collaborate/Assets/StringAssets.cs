using System;

namespace Unity.Cloud.Collaborate.Assets
{
    /// <summary>
    /// Static string resources used throughout the UI.
    /// </summary>
    internal static class StringAssets
    {
        public const string searchResults = "Search Results";
        public const string cannotPublishWhileSearching = "Please clear the search before publishing changes.";
        public const string cannotPublishWhileConflicted = "Please fix the above conflicts before publishing.";
        public const string cannotPublishWithoutFiles = "No files to publish.";
        public const string cannotPublishWithIncomingChanges = "Please sync latest changes before publishing.";
        public const string changeListFullHeader = "Publish Changes";
        public const string changeListConflictedHeader = "Conflicted Items";
        public const string changeListConflictedList = "conflicted";
        public const string noticeNoRevisionsToDisplay = "No revisions to display.";
        public const string noticeNoChangesToDisplay = "No changes to display.";
        public const string noticeNoResultsForQuery = "No results found for this query.";
        public const string publishButton = "Publish";
        public const string publishSummaryPlaceholder = "Summary";
        public const string menuDiscardToggledChanges = "Discard toggled changes";
        public const string cancel = "Cancel";
        public const string discardChanges = "Discard changes";
        public const string confirmDiscardChangeMessage = "Are you sure you want to irreversibly discard changes to a file?";
        public const string confirmDiscardChangesMessage = "Are you sure you want to irreversibly discard changes to {0} files?";
        public const string confirmDiscardChangesTitle = "Collaborate: discard changes";
        public const string search = "Search";
        public const string syncRemoteRevisionMessage = "1 revision has been published to the server. Please sync to get the latest changes.";
        public const string syncRemoteRevisionsMessage = "Some revisions have been published to the server. Please sync to get the latest changes.";
        public const string syncLocalRevisionMessage = "1 revision has been made locally, but hasn't been published to the server. Please sync to ensure these changes are published.";
        public const string syncLocalRevisionsMessage = "{0} revisions have been made locally, but haven't been published to the server. Please sync to ensure these changes are published.";
        public const string sync = "Sync";
