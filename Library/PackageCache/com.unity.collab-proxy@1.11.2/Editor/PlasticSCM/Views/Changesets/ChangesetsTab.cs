using System;
using System.Collections.Generic;

using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

using Codice.Client.Commands;
using Codice.Client.Common.Threading;
using Codice.CM.Common;
using PlasticGui;
using PlasticGui.WorkspaceWindow.QueryViews;
using PlasticGui.WorkspaceWindow.QueryViews.Changesets;
using Unity.PlasticSCM.Editor.UI;
using Unity.PlasticSCM.Editor.UI.Progress;
using Unity.PlasticSCM.Editor.UI.Tree;
using Unity.PlasticSCM.Editor.Views.Diff;
using Codice.Client.BaseCommands.EventTracking;

namespace Unity.PlasticSCM.Editor.Views.Changesets
{
    internal class ChangesetsTab :
        IRefreshableView,
        IChangesetMenuOperations,
        ChangesetsViewMenu.IMenuOperations
    {
        internal ChangesetsTab(
            WorkspaceInfo wkInfo,
