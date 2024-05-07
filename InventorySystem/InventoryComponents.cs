public abstract class InventoryBase
{


    /// <summary>
    /// Tries to add item to inventory if possible
    /// </summary>
    /// <returns>True if succesful</returns>
    public abstract bool TryAddItem();
}

public class InventorySlot
{
    public required Item item;
}

/// <summary>
/// Represents a stack of items inside an inventory or inventory slot. Includes information like stack size and item type.
/// </summary>
public class Item
{
    public required ItemType Type;
}

/// <summary>
/// Represents a type of item. This is used to define the properties of an item.
/// </summary>
public class ItemType
{
    public int MaxStackSize;
    public string Name;
    public string ShortDescription;

    public ItemType(int maxStackSize = 24, string name = "Unnamed item", string shortDescription = "No description.")
    {
        MaxStackSize = maxStackSize;
        Name = name;
        ShortDescription = shortDescription;
    }
}

/// <summary>
/// Inventory class which stores item stacks in simple list.
/// </summary>
public class ListInventory : InventoryBase
{
    public override bool TryAddItem()
    {
        throw new NotImplementedException();
    }
}

public class GridInventory : InventoryBase
{


    public override bool TryAddItem()
    {
        throw new NotImplementedException();
    }
}