using System.Collections.Generic;

using Codice.CM.Common;
using Unity.PlasticSCM.Editor.UI.Tree;

namespace Unity.PlasticSCM.Editor.Views.Changesets
{
    internal static class ChangesetsSelection
    {
        internal static void SelectChangesets(
            ChangesetsListView listView,
            List<RepObjectInfo> csetsToSelect,
