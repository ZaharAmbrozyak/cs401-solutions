namespace midterm_prep;

public class Library
{
    private List<IMaterial> materials = [];

    public void AddMaterial(IMaterial material)
    {
        materials.Add(material);
    }

    public string ShowMaterials()
    {
        var output = "Materials\n";
        foreach (var material in materials)
        {
            output += material.Show();
        }

        return output;
    }
}