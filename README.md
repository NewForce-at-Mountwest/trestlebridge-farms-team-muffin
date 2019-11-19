![trestlebridge farm landscape](./Trestlebridge.jpg)


# Trestlebridge Farms

You and your friends have decided to connect with the earth again and abandon your reliance on technology and urban vices. You have built a business plan, presented it to a bank, and have secured $5 million to purchase an abandoned farm and produce high quality care and growth.

You have met with other growers and ranchers in the Middle Tennessee area and have decided on the animals and plants below to build your farm. For each resource, you will find where it will be stored on the farm, what is produces when processed, and how much it produces.

## Livestock

| | Cows  | Pigs  | Chickens  | Ducks | Goats | Ostriches | Sheep |
|---|---|---|---|---|---|--|--|
| **Location** |  Grazing Fields | Grazing Fields | Chicken House | Duck House | Grazing Fields | Grazing Fields | Grazing Fields |
| **Feed per day** | 5.4kg | 3.2kg | 0.9kg | 0.8 kg | 4.1kg | 2.3kg | 4kg |
| **Amount** | 18.25kg | 8.4kg | 7 / .5kg / 1.7kg | 6 / .75kg |  7.5kg | 3 / 2.6kg | 5kg |


## Seed

When you purchase seeds, you purchase enough for an entire row of plants in a field.

| | Sunflower | Wildflower | Sesame |
|---|---|---|---|
|**Location**| Plowed or Natural Field | Natural Field  | Plowed Field |
|**Product**| Seed / Compost | Compost | Seed |
|**Amount**| 650 / 21.6kg | 30.3kg | 520 |

## Storage Facilities

Listed below are the capacities of each storage facility.

| Plowed Field | Natural Field | Grazing Field | Chicken House | Duck House |
|---|---|---|---|---|
| 13 rows of plants <br/> 5 plants per row | 10 rows of plants <br/> 6 plants per row | 20 grazers | 15 | 12 |


## Farm Animals and Raw Materials System (FARMS)

> _"We don't need no stinkin' JavaScript!"_
>  -- Jayden Michaels (a.k.a. RetroMan)

Fancy web applications are so 2017. Command line applications provide a much more hands-on, personal, bespoke, artisinal experience when managing a farm such as Trestlebridge. Therefore, even though you are casting off your digital personas to lead a life connected with the land, you still want to use your hard-earned skills as developers to make management of your farm as efficient as possible.

Here are the main features that the application will provide.
### Main Menu

When the user first executes FARMS, they should be welcomed to the system and be presented with the following menu.

```sh
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
 |T||r||e||s||t||l||e||b||r||i||d||g||e|
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
           |F||a||r||m||s|
           +-++-++-++-++-+

1. Create Facility
2. Purchase Animals
3. Purchase Seeds
4. Processing Options (this is a stretch goal)

Choose a FARMS option.
> _
```

### Facility Creation Options Sub-Menu

If the user chooses option 1, then the following menu should be displayed

```sh
1. Grazing field
2. Plowed field
3. Natural field
4. Chicken house
5. Duck house

Choose what you want to create.
> _
```

When the user makes a choice, a new instance of that type of facility should be added to a `List<>` on your farm.

### Animal Purchase Menu

If the user chooses 2 from the main menu, then they should see the following menu, with the animals listed as live stock.

```sh
1. Cow
2. Ostrich
3. Goat
4. Pig
5. Sheep
6. Chicken
7. Duck

Choose animals to purchase.
> _
```

When the user enters in what to buy, then display all of the locations in which the animals can be stored.

```sh
1. Grazing Field
2. Grazing Field

Where would you like to place the animals?
> _
```

If the user chose to place them in a location that would be over capacity if they were placed there, display a message and show the menu again.

```sh
**** That facililty is not large enough ****
****     Please choose another one      ****

1. Grazing Field
2. Grazing Field

Where would you like to place the animals?
> _
```

### Seed Purchase Menu

If the user chooses 3 from the main menu, then she should see the following menu, with the plants listed in alphabetical order. You purchase enough seeds for an entire row at a time.

```sh
1. Sesame
2. Sunflower
3. Wildflower

Choose seed to purchase.
> _
```

When the user makes a choice, then display all of the locations in which the plants can be planted. The current number of plant rows should be displayed for each location.

```sh
1. Plowed Field
2. Plowed Field
3. Natural Field

Where would you like to plant the Sunflowers?
> _
```

If the user chose to place them in a location that would be over capacity if they were placed there, display a message and show the menu again.

```sh
**** That facililty is not large enough ****
****     Please choose another one      ****

1. Plowed Field
2. Plowed Field
3. Natural Field

Where would you like to plant the Sunflowers?
> _
```
