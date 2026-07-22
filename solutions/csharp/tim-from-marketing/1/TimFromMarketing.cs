static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if(department == null && id != null) return $"[{id}] - {name} - OWNER";
        else if(id == null) return $"{name} - {department?.ToUpper() ?? "OWNER"}";
        else return $"[{id}] - {name} - {department.ToUpper()}";
    }
}
