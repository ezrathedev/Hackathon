namespace DefaultNamespace;

public class NeighborhoodService
{
    public async Task<NeighborhoodPageVm> NeighborhoodOverview()
    {
        var npvm = new NeighborhoodPageVm();
        
        npvm.food = "Availability of vegan food: Vegans are likely to prefer neighborhoods with a variety of restaurants and grocery stores that offer vegan options. This could include vegan-friendly restaurants, health food stores, and farmers markets.";

        npvm.walkbike = "Walkability or bikeability: Many vegans are environmentally conscious and may prefer neighborhoods that are walkable or bikeable, reducing the need for cars and minimizing their carbon footprint.";

        npvm.green = "Access to green spaces: Veganism often goes hand-in-hand with a love for nature and animals. Neighborhoods with parks, nature reserves, or hiking trails may be more attractive to vegans.";

        npvm.community = "Community support: Many vegans appreciate being part of a supportive community. Neighborhoods with a strong vegan community or local organizations that promote veganism may be more appealing.";

        npvm.animals = "Animal-friendly amenities: Vegans may also appreciate neighborhoods with animal-friendly amenities, such as dog parks, animal shelters, and wildlife rehabilitation centers.";
        
        npvm.houses = "Non-toxic cleaning supplies. Vegan-friendly materials. Energy-efficient features.";
        
        return npvm;
    }
}