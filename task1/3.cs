class View
{
    private Shop shop;

    private List<User> FilterUsers(List<User> users, decimal koef)
    {
        List<User> activeUsers = new List<User>();
        foreach(User user  in users)
        {
            if(shop.IsActiveUser(user, koef))
            {
                activeUsers.Add(user);
            }
        }
        return activeUsers;
    }
}

class Shop
{
    public bool IsActiveUser(User user, decimal koef)
    {
        decimal rate = 1;
        if(koef > 1000)
        {
            rate  = koef * 1.75;
        }
        return user.Boss || user.HasDiscount() && rate > 10;
    }
}

class User
{
    private bool boss;

    public bool Boss
    {
        get { return boss; }
    }
    
    public bool HasDiscount()
    {
         // some condition
    }
}