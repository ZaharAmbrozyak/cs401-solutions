namespace midterm_prep;

public class Library
{
    private List<IShowable> materials = [];

    public void AddMaterial(IShowable showable)
    {
        materials.Add(showable);
    }

    public string ShowMaterials()
    {
        var output = "Materials\n";
        foreach (var material in materials)
        {
            output += material.Show() + "\n";
        }

        return output;
    }
}