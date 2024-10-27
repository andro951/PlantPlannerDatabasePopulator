

namespace PlantPlannerDatabasePopulator {
	class Program {
		static List<Plant> plants = new() {
			new Plant("Rose", "Shrub", "Rosaceae", 2.0, -10.0, 30.0, "Full Sun", 6.0, 30.0, 70.0, 6.0, 7.5, 1.0, 0.5, 30.0, "Balanced Fertilizer", "Well-draining, Loamy", "https://example.com/images/rose.jpg"),
			new Plant("Aloe Vera", "Succulent", "Asphodelaceae", 14.0, 10.0, 30.0, "Partial Sun", 4.0, 20.0, 50.0, 6.0, 8.0, 0.5, 0.3, 90.0, "Cactus Fertilizer", "Well-draining, Sandy", "https://example.com/images/aloe_vera.jpg"),
			new Plant("Snake Plant", "Indoor Foliage", "Asparagaceae", 14.0, 15.0, 30.0, "Low to Bright Indirect Light", 3.0, 20.0, 60.0, 6.0, 7.5, 1.0, 0.3, 60.0, "General Houseplant Fertilizer", "Well-draining, Loamy", "https://example.com/images/snake_plant.jpg"),
			new Plant("Tomato", "Fruit", "Solanaceae", 3.0, 15.0, 30.0, "Full Sun", 8.0, 50.0, 80.0, 5.5, 7.0, 1.8, 0.6, 14.0, "Vegetable Fertilizer", "Rich, Loamy", "https://example.com/images/tomato.jpg"),
			new Plant("Peace Lily", "Indoor Foliage", "Araceae", 7.0, 18.0, 30.0, "Low to Medium Indirect Light", 4.0, 40.0, 70.0, 5.5, 7.0, 0.7, 0.5, 30.0, "General Houseplant Fertilizer", "Moist, Well-draining", "https://example.com/images/peace_lily.jpg"),
			new Plant("Lavender", "Herb", "Lamiaceae", 5.0, -5.0, 35.0, "Full Sun", 8.0, 40.0, 60.0, 6.5, 8.0, 0.6, 0.5, 60.0, "Herb Fertilizer", "Sandy, Well-draining", "https://example.com/images/lavender.jpg"),
			new Plant("Fiddle Leaf Fig", "Indoor Foliage", "Moraceae", 7.0, 16.0, 30.0, "Bright Indirect Light", 6.0, 30.0, 65.0, 6.0, 7.0, 2.0, 1.5, 60.0, "General Houseplant Fertilizer", "Well-draining, Loamy", "https://example.com/images/fiddle_leaf_fig.jpg"),
			new Plant("Philodendron", "Indoor Foliage", "Araceae", 7.0, 18.0, 28.0, "Low to Medium Indirect Light", 5.0, 40.0, 70.0, 5.0, 7.5, 0.9, 0.6, 45.0, "General Houseplant Fertilizer", "Well-draining, Loamy", "https://example.com/images/philodendron.jpg"),
			new Plant("Orchid", "Flowering Plant", "Orchidaceae", 7.0, 15.0, 30.0, "Bright Indirect Light", 8.0, 60.0, 80.0, 5.5, 6.5, 0.6, 0.4, 30.0, "Orchid Fertilizer", "Bark-based, Well-draining", "https://example.com/images/orchid.jpg"),
			new Plant("Bamboo", "Grass", "Poaceae", 2.0, 10.0, 35.0, "Full Sun to Partial Shade", 6.0, 50.0, 90.0, 5.5, 6.5, 15.0, 0.5, 30.0, "General Plant Fertilizer", "Moist, Well-draining", "https://example.com/images/bamboo.jpg"),
			new Plant("Rosemary", "Herb", "Lamiaceae", 3.0, 5.0, 30.0, "Full Sun", 6.0, 30.0, 70.0, 6.0, 7.0, 0.8, 0.8, 30.0, "Herb Fertilizer", "Well-draining, Sandy", "https://example.com/images/rosemary.jpg"),
			new Plant("Thyme", "Herb", "Lamiaceae", 3.0, 5.0, 30.0, "Full Sun", 6.0, 30.0, 70.0, 5.5, 7.5, 0.2, 0.4, 21.0, "Herb Fertilizer", "Well-draining, Sandy", "https://example.com/images/thyme.jpg"),
			new Plant("Monstera", "Indoor Foliage", "Araceae", 7.0, 15.0, 30.0, "Bright Indirect Light", 6.0, 40.0, 70.0, 6.0, 7.0, 2.0, 1.5, 60.0, "General Houseplant Fertilizer", "Well-draining, Loamy", "https://example.com/images/monstera.jpg"),
			new Plant("Basil", "Herb", "Lamiaceae", 3.0, 10.0, 35.0, "Full Sun", 6.0, 50.0, 80.0, 5.5, 7.5, 0.5, 0.3, 21.0, "Herb Fertilizer", "Well-draining, Loamy", "https://example.com/images/basil.jpg"),
			new Plant("Dracaena", "Indoor Foliage", "Asparagaceae", 14.0, 18.0, 27.0, "Low to Bright Indirect Light", 6.0, 30.0, 70.0, 6.0, 7.0, 1.5, 1.2, 90.0, "General Houseplant Fertilizer", "Well-draining, Loamy", "https://example.com/images/dracaena.jpg"),
			new Plant("Mint", "Herb", "Lamiaceae", 3.0, 10.0, 30.0, "Partial Sun", 5.0, 50.0, 80.0, 6.0, 7.5, 0.3, 0.3, 15.0, "Herb Fertilizer", "Moist, Loamy", "https://example.com/images/mint.jpg"),
			new Plant("Corn Plant", "Indoor Foliage", "Asparagaceae", 14.0, 16.0, 27.0, "Low to Medium Indirect Light", 6.0, 30.0, 60.0, 5.0, 6.5, 1.5, 1.2, 60.0, "General Houseplant Fertilizer", "Well-draining, Loamy", "https://example.com/images/corn_plant.jpg"),
			new Plant("Lettuce", "Leafy Vegetable", "Asteraceae", 2.0, 7.0, 24.0, "Full Sun to Partial Shade", 6.0, 50.0, 70.0, 6.0, 7.0, 0.2, 0.3, 14.0, "Vegetable Fertilizer", "Rich, Moist Soil", "https://example.com/images/lettuce.jpg"),
			new Plant("Lemon Tree", "Fruit Tree", "Rutaceae", 7.0, 10.0, 40.0, "Full Sun", 8.0, 50.0, 60.0, 5.5, 6.5, 5.0, 3.0, 60.0, "Citrus Fertilizer", "Sandy, Well-draining", "https://example.com/images/lemon_tree.jpg"),
			new Plant("Pothos", "Indoor Foliage", "Araceae", 7.0, 18.0, 30.0, "Low to Medium Indirect Light", 5.0, 40.0, 70.0, 6.0, 7.5, 1.2, 0.3, 60.0, "General Houseplant Fertilizer", "Moist, Well-draining", "https://example.com/images/pothos.jpg"),
			new Plant("Spider Plant", "Indoor Foliage", "Asparagaceae", 7.0, 10.0, 30.0, "Indirect Light", 5.0, 40.0, 70.0, 6.0, 7.5, 0.6, 0.6, 30.0, "General Houseplant Fertilizer", "Well-draining, Loamy", "https://example.com/images/spider_plant.jpg"),
			new Plant("Parlor Palm", "Indoor Foliage", "Arecaceae", 14.0, 15.0, 27.0, "Low to Medium Indirect Light", 5.0, 30.0, 60.0, 5.0, 7.5, 1.2, 1.0, 60.0, "General Houseplant Fertilizer", "Well-draining, Loamy", "https://example.com/images/parlor_palm.jpg"),
			new Plant("Zebra Plant", "Indoor Foliage", "Acanthaceae", 7.0, 18.0, 30.0, "Bright Indirect Light", 6.0, 50.0, 80.0, 5.5, 6.5, 0.6, 0.3, 30.0, "Houseplant Fertilizer", "Moist, Well-draining", "https://example.com/images/zebra_plant.jpg"),
			new Plant("Swiss Cheese Plant", "Indoor Foliage", "Araceae", 7.0, 15.0, 30.0, "Bright Indirect Light", 6.0, 50.0, 70.0, 6.0, 7.5, 2.0, 1.5, 30.0, "General Houseplant Fertilizer", "Well-draining, Loamy", "https://example.com/images/swiss_cheese_plant.jpg"),
			new Plant("Cilantro", "Herb", "Apiaceae", 3.0, 10.0, 30.0, "Partial Sun", 6.0, 50.0, 80.0, 6.0, 7.5, 0.5, 0.3, 15.0, "Herb Fertilizer", "Moist, Loamy", "https://example.com/images/cilantro.jpg"),
			new Plant("Petunia", "Flowering Annual", "Solanaceae", 3.0, 15.0, 30.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.2, 0.3, 14.0, "Flower Fertilizer", "Well-draining, Loamy", "https://example.com/images/petunia.jpg"),
			new Plant("Cucumber", "Fruit Vegetable", "Cucurbitaceae", 3.0, 10.0, 35.0, "Full Sun", 7.0, 60.0, 80.0, 6.0, 6.5, 1.0, 0.8, 20.0, "Vegetable Fertilizer", "Well-draining, Loamy", "https://example.com/images/cucumber.jpg"),
			new Plant("Carrot", "Root Vegetable", "Apiaceae", 2.0, 5.0, 25.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.5, 0.3, 14.0, "Root Vegetable Fertilizer", "Sandy, Well-draining", "https://example.com/images/carrot.jpg"),
			new Plant("Beetroot", "Root Vegetable", "Amaranthaceae", 2.0, 5.0, 25.0, "Full Sun to Partial Shade", 6.0, 50.0, 70.0, 6.0, 7.0, 0.5, 0.3, 14.0, "Root Vegetable Fertilizer", "Loamy, Well-draining", "https://example.com/images/beetroot.jpg"),
			new Plant("Cauliflower", "Cruciferous Vegetable", "Brassicaceae", 3.0, 5.0, 25.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.5, 0.3, 15.0, "Vegetable Fertilizer", "Rich, Well-draining", "https://example.com/images/cauliflower.jpg"),
			new Plant("Fuchsia", "Flowering Shrub", "Onagraceae", 3.0, 10.0, 30.0, "Partial Shade", 6.0, 40.0, 70.0, 6.0, 7.5, 0.5, 0.4, 30.0, "Flower Fertilizer", "Moist, Well-draining", "https://example.com/images/fuchsia.jpg"),
			new Plant("Jade Plant", "Succulent", "Crassulaceae", 14.0, 15.0, 30.0, "Bright Indirect Light", 4.0, 20.0, 50.0, 6.0, 7.5, 0.3, 0.2, 90.0, "Cactus Fertilizer", "Well-draining, Sandy", "https://example.com/images/jade_plant.jpg"),
			new Plant("Chrysanthemum", "Flowering Plant", "Asteraceae", 3.0, 15.0, 30.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.6, 0.4, 30.0, "Flower Fertilizer", "Well-draining, Loamy", "https://example.com/images/chrysanthemum.jpg"),
			new Plant("Bell Pepper", "Fruit Vegetable", "Solanaceae", 3.0, 15.0, 30.0, "Full Sun", 8.0, 50.0, 80.0, 5.5, 7.0, 1.5, 0.6, 14.0, "Vegetable Fertilizer", "Rich, Loamy", "https://example.com/images/bell_pepper.jpg"),
			new Plant("Pansy", "Flowering Annual", "Violaceae", 3.0, 10.0, 30.0, "Full Sun to Partial Shade", 6.0, 50.0, 70.0, 6.0, 7.0, 0.3, 0.3, 15.0, "Flower Fertilizer", "Well-draining, Loamy", "https://example.com/images/pansy.jpg"),
			new Plant("Peony", "Perennial Flower", "Paeoniaceae", 3.0, -5.0, 30.0, "Full Sun to Partial Shade", 6.0, 40.0, 70.0, 6.0, 7.5, 1.0, 0.5, 30.0, "Balanced Fertilizer", "Well-draining, Loamy", "https://example.com/images/peony.jpg"),
			new Plant("Hibiscus", "Flowering Shrub", "Malvaceae", 3.0, 10.0, 35.0, "Full Sun", 8.0, 60.0, 80.0, 6.0, 7.0, 1.2, 0.5, 30.0, "Flower Fertilizer", "Well-draining, Loamy", "https://example.com/images/hibiscus.jpg"),
			new Plant("Zinnia", "Flowering Annual", "Asteraceae", 3.0, 10.0, 30.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.4, 0.3, 15.0, "Flower Fertilizer", "Well-draining, Loamy", "https://example.com/images/zinnia.jpg"),
			new Plant("Citrus Tree", "Fruit Tree", "Rutaceae", 7.0, 10.0, 40.0, "Full Sun", 8.0, 50.0, 60.0, 5.5, 6.5, 5.0, 3.0, 60.0, "Citrus Fertilizer", "Sandy, Well-draining", "https://example.com/images/citrus_tree.jpg"),
			new Plant("Coleus", "Foliage Plant", "Lamiaceae", 3.0, 15.0, 30.0, "Partial Shade", 5.0, 40.0, 60.0, 6.0, 7.0, 0.5, 0.4, 30.0, "General Houseplant Fertilizer", "Well-draining, Loamy", "https://example.com/images/coleus.jpg"),
			new Plant("Astilbe", "Perennial Flower", "Saxifragaceae", 3.0, 5.0, 25.0, "Partial Shade", 6.0, 40.0, 70.0, 6.0, 7.5, 0.8, 0.4, 30.0, "Balanced Fertilizer", "Moist, Well-draining", "https://example.com/images/astilbe.jpg"),
			new Plant("Snapdragon", "Flowering Annual", "Plantaginaceae", 3.0, 5.0, 30.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.5, 0.3, 14.0, "Flower Fertilizer", "Well-draining, Loamy", "https://example.com/images/snapdragon.jpg"),
			new Plant("Marigold", "Flowering Annual", "Asteraceae", 3.0, 5.0, 30.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.4, 0.3, 14.0, "Flower Fertilizer", "Well-draining, Loamy", "https://example.com/images/marigold.jpg"),
			new Plant("Lavender", "Herb", "Lamiaceae", 5.0, -5.0, 35.0, "Full Sun", 8.0, 40.0, 60.0, 6.5, 8.0, 0.6, 0.5, 60.0, "Herb Fertilizer", "Sandy, Well-draining", "https://example.com/images/lavender_2.jpg"),
			new Plant("Ornamental Grass", "Grass", "Poaceae", 2.0, 10.0, 30.0, "Full Sun", 6.0, 50.0, 80.0, 5.5, 6.5, 15.0, 0.5, 30.0, "General Plant Fertilizer", "Moist, Well-draining", "https://example.com/images/ornamental_grass.jpg"),
			new Plant("Peach Tree", "Fruit Tree", "Rosaceae", 7.0, 10.0, 40.0, "Full Sun", 8.0, 50.0, 60.0, 5.5, 6.5, 5.0, 3.0, 60.0, "Fruit Tree Fertilizer", "Sandy, Well-draining", "https://example.com/images/peach_tree.jpg"),
			new Plant("Potato", "Root Vegetable", "Solanaceae", 3.0, 10.0, 30.0, "Full Sun", 6.0, 50.0, 80.0, 5.0, 7.0, 0.5, 0.4, 15.0, "Vegetable Fertilizer", "Rich, Well-draining", "https://example.com/images/potato.jpg"),
			new Plant("Bell Pepper", "Fruit Vegetable", "Solanaceae", 3.0, 15.0, 30.0, "Full Sun", 6.0, 50.0, 80.0, 6.0, 7.0, 1.0, 0.4, 20.0, "Vegetable Fertilizer", "Rich, Loamy", "https://example.com/images/bell_pepper.jpg"),
			new Plant("Radish", "Root Vegetable", "Brassicaceae", 2.0, 5.0, 25.0, "Full Sun", 5.0, 50.0, 70.0, 6.0, 7.0, 0.3, 0.3, 14.0, "Vegetable Fertilizer", "Well-draining, Loamy", "https://example.com/images/radish.jpg"),
			new Plant("Zucchini", "Fruit Vegetable", "Cucurbitaceae", 3.0, 10.0, 35.0, "Full Sun", 7.0, 60.0, 80.0, 6.0, 6.5, 1.0, 0.8, 20.0, "Vegetable Fertilizer", "Well-draining, Loamy", "https://example.com/images/zucchini.jpg"),
			new Plant("Pumpkin", "Fruit Vegetable", "Cucurbitaceae", 4.0, 10.0, 40.0, "Full Sun", 7.0, 60.0, 80.0, 6.0, 6.5, 2.0, 1.5, 25.0, "Vegetable Fertilizer", "Well-draining, Loamy", "https://example.com/images/pumpkin.jpg"),
			new Plant("Squash", "Fruit Vegetable", "Cucurbitaceae", 4.0, 10.0, 35.0, "Full Sun", 7.0, 60.0, 80.0, 6.0, 6.5, 1.5, 1.0, 20.0, "Vegetable Fertilizer", "Well-draining, Loamy", "https://example.com/images/squash.jpg"),
			new Plant("Chili Pepper", "Fruit Vegetable", "Solanaceae", 3.0, 15.0, 30.0, "Full Sun", 6.0, 50.0, 80.0, 6.0, 7.0, 1.5, 0.6, 20.0, "Vegetable Fertilizer", "Rich, Loamy", "https://example.com/images/chili_pepper.jpg"),
			new Plant("Eggplant", "Fruit Vegetable", "Solanaceae", 3.0, 15.0, 30.0, "Full Sun", 6.0, 50.0, 80.0, 5.5, 7.0, 1.2, 0.5, 20.0, "Vegetable Fertilizer", "Rich, Loamy", "https://example.com/images/eggplant.jpg"),
			new Plant("Peas", "Legume", "Fabaceae", 2.0, 5.0, 25.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.5, 0.3, 15.0, "Legume Fertilizer", "Well-draining, Loamy", "https://example.com/images/peas.jpg"),
			new Plant("Asparagus", "Perennial Vegetable", "Asparagaceae", 3.0, 10.0, 30.0, "Full Sun", 6.0, 50.0, 80.0, 6.5, 7.0, 1.0, 0.5, 20.0, "Vegetable Fertilizer", "Well-draining, Sandy", "https://example.com/images/asparagus.jpg"),
			new Plant("Spinach", "Leafy Vegetable", "Amaranthaceae", 2.0, 5.0, 25.0, "Partial Sun", 6.0, 50.0, 70.0, 6.5, 7.0, 0.3, 0.3, 14.0, "Vegetable Fertilizer", "Rich, Moist Soil", "https://example.com/images/spinach.jpg"),
			new Plant("Artichoke", "Vegetable", "Asteraceae", 4.0, 10.0, 35.0, "Full Sun", 6.0, 50.0, 80.0, 6.0, 7.0, 1.5, 0.5, 25.0, "Vegetable Fertilizer", "Rich, Well-draining", "https://example.com/images/artichoke.jpg"),
			new Plant("Broccoli", "Cruciferous Vegetable", "Brassicaceae", 3.0, 5.0, 25.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.5, 0.4, 20.0, "Vegetable Fertilizer", "Rich, Well-draining", "https://example.com/images/broccoli.jpg"),
			new Plant("Mango", "Fruit Tree", "Anacardiaceae", 7.0, 20.0, 50.0, "Full Sun", 8.0, 50.0, 70.0, 5.5, 6.5, 3.0, 2.0, 80.0, "Citrus Fertilizer", "Well-draining, Loamy", "https://example.com/images/mango.jpg"),
			new Plant("Peach", "Fruit Tree", "Rosaceae", 7.0, 15.0, 40.0, "Full Sun", 8.0, 50.0, 70.0, 5.5, 6.5, 2.5, 1.5, 70.0, "Fruit Tree Fertilizer", "Well-draining, Loamy", "https://example.com/images/peach.jpg"),
			new Plant("Pear", "Fruit Tree", "Rosaceae", 7.0, 10.0, 40.0, "Full Sun", 8.0, 50.0, 70.0, 5.5, 6.5, 3.0, 1.5, 70.0, "Fruit Tree Fertilizer", "Well-draining, Loamy", "https://example.com/images/pear.jpg"),
			new Plant("Plum", "Fruit Tree", "Rosaceae", 7.0, 10.0, 40.0, "Full Sun", 8.0, 50.0, 70.0, 5.5, 6.5, 3.0, 1.5, 70.0, "Fruit Tree Fertilizer", "Well-draining, Loamy", "https://example.com/images/plum.jpg"),
			new Plant("Cherry", "Fruit Tree", "Rosaceae", 7.0, 10.0, 40.0, "Full Sun", 8.0, 50.0, 70.0, 5.5, 6.5, 2.5, 1.5, 70.0, "Fruit Tree Fertilizer", "Well-draining, Loamy", "https://example.com/images/cherry.jpg"),
			new Plant("Blackberry", "Fruit Bramble", "Rosaceae", 2.0, 10.0, 30.0, "Full Sun", 6.0, 50.0, 80.0, 5.5, 7.0, 1.0, 0.4, 20.0, "Berry Fertilizer", "Well-draining, Loamy", "https://example.com/images/blackberry.jpg"),
			new Plant("Raspberry", "Fruit Bramble", "Rosaceae", 2.0, 10.0, 30.0, "Full Sun", 6.0, 50.0, 80.0, 5.5, 7.0, 1.0, 0.4, 20.0, "Berry Fertilizer", "Well-draining, Loamy", "https://example.com/images/raspberry.jpg"),
			new Plant("Grapes", "Fruit Vine", "Vitaceae", 6.0, 15.0, 40.0, "Full Sun", 7.0, 50.0, 70.0, 6.0, 7.0, 1.5, 1.0, 25.0, "Grape Fertilizer", "Well-draining, Sandy", "https://example.com/images/grapes.jpg"),
			new Plant("Cabbage", "Leafy Vegetable", "Brassicaceae", 2.0, 5.0, 25.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.5, 0.3, 15.0, "Vegetable Fertilizer", "Well-draining, Loamy", "https://example.com/images/cabbage.jpg"),
			new Plant("Kale", "Leafy Vegetable", "Brassicaceae", 2.0, 5.0, 25.0, "Full Sun", 6.0, 50.0, 70.0, 6.0, 7.0, 0.3, 0.3, 15.0, "Vegetable Fertilizer", "Rich, Moist Soil", "https://example.com/images/kale.jpg"),

		};

		static void Main() {
			string csvPath = Path.Combine(Directory.GetCurrentDirectory(), "plants.csv");
			$"csvPath: {csvPath}".Write();
			using (StreamWriter writer = new StreamWriter(csvPath)) {
				writer.WriteLine($"{nameof(Plant.Name)},{nameof(Plant.Type)},{nameof(Plant.Family)},{nameof(Plant.WateringFrequency)},{nameof(Plant.MinTemperatureCelsius)},{nameof(Plant.MaxTemperatureCelsius)},{nameof(Plant.LightType)},{nameof(Plant.HoursOfLightPerDay)},{nameof(Plant.MinHumidity)},{nameof(Plant.MaxHumidity)},{nameof(Plant.MinPH)},{nameof(Plant.MaxPH)},{nameof(Plant.ExpectedHeightMeters)},{nameof(Plant.ExpectedWidthMeters)},{nameof(Plant.FertilizerFrequencyInDays)},{nameof(Plant.FertilizerType)},{nameof(Plant.SoilType)},{nameof(Plant.ImageUrl)}");
				foreach (Plant plant in plants) {
					writer.WriteLine($"{EscapeCsvValue(plant.Name)},{EscapeCsvValue(plant.Type)},{EscapeCsvValue(plant.Family)},{plant.WateringFrequency},{plant.MinTemperatureCelsius},{plant.MaxTemperatureCelsius},{EscapeCsvValue(plant.LightType)},{plant.HoursOfLightPerDay},{plant.MinHumidity},{plant.MaxHumidity},{plant.MinPH},{plant.MaxPH},{plant.ExpectedHeightMeters},{plant.ExpectedWidthMeters},{plant.FertilizerFrequencyInDays},{EscapeCsvValue(plant.FertilizerType)},{EscapeCsvValue(plant.SoilType)},{EscapeCsvValue(plant.ImageUrl)}");
				}
			}
			"Finished Writing plants to csv file.".Write();
		}
		private static string EscapeCsvValue(string value) {
			if (value.Contains(",") || value.Contains("\"")) {
				value = value.Replace("\"", "\"\"");
				value = $"\"{value}\""; // Enclose in quotes
			}
			return value;
		}
	}
}