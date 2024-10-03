using Apimarket.Models;

public class ResponsibleServices
{
    private readonly AppDbContext _context;

    public ResponsibleServices(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Responsible> GetResponsible()
    {
        return _context.responsible.ToList();
    }
}
