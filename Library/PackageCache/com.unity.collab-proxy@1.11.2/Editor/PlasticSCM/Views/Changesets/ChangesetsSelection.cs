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
            int defaultRow)
        {
            if (csetsToSelect == null || csetsToSelect.Count == 0)
            {
                TableViewOperations.SelectFirstRow(listView);
                return;
            }

            listView.SelectRepObjectInfos(csetsToSelect);

            if (listView.HasSelection())
                return;

            TableViewOperations.SelectDefaultRow(listView, defaultRow);

            if (listView.HasSelection())
                return;

            TableViewOperations.SelectFirstRow(listView);
        }

        internal static List<RepObjectInfo> GetSelectedRepObjectInfos(
            ChangesetsListView listView)
        {
            return listView.GetSelectedRepObjectInfos();
        }

        internal static int GetSelectedChangesetsCount(
            ChangesetsListView listView)
