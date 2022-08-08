using BlazorTutorial.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorTutorial.Shared
{
    public partial class Grid<TItem> where TItem: IItem, new() 
    {
        private List<string> editEvents = new();
        private bool dense = false;
        private bool hover = true;
        private bool ronly = false;
        private bool canCancelEdit = false;
        private bool blockSwitch = false;
        private string searchString = "";
        private TItem selectedItem1 = default(TItem);

        private TItem ItemBeforeEdit;

        private HashSet<TItem> selectedItems1 = new HashSet<TItem>();
        
        [Parameter]
        public GridData<TItem> Data{ get; set; }
        
        private void ClearEventLog()
        {
            editEvents.Clear();
        }

        private void AddEditionEvent(string message)
        {
            editEvents.Add(message);
            StateHasChanged();
        }

        private void BackupItem(object Item)
        {
            ItemBeforeEdit = (TItem)Item;
            AddEditionEvent($"RowEditPreview event: made a backup of Item");
        }

        private void ItemHasBeenCommitted(object Item)
        {
            AddEditionEvent($"RowEditCommit event: Changes to Item committed");
        }

        private void ResetItemToOriginalValues(object Item)
        {
            Item = ItemBeforeEdit;
            AddEditionEvent($"RowEditCancel event: Editing of Item cancelled");
        }

        private bool FilterFunc(TItem Item)
        {

            //if (string.IsNullOrWhiteSpace(searchString))
            //    return true;
            //if (Item.FirstName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            //    return true;
            //if (Item.LastName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            //    return true;
            //if ($"{Item.Street} {Item.City} {Item.State}".Contains(searchString))
            //    return true;

            return true;
        }
    }
}