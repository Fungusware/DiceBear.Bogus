# DiceBear.Bogus

Generates deterministic Avatars using the amazing DiceBear Avatar Library

Check it out here. https://www.dicebear.com/


# Examples

## Botts

<img src="https://api.dicebear.com/9.x/bottts/svg?seed=Jimmy" height="90px">
<img src="https://api.dicebear.com/9.x/bottts/svg?seed=Luna" height="90px">
<img src="https://api.dicebear.com/9.x/bottts/svg?seed=Bobby" height="90px">
<img src="https://api.dicebear.com/9.x/bottts/svg?seed=Linda" height="90px">

## Open Peeps
<img src="https://api.dicebear.com/9.x/open-peeps/svg?seed=Jimmy" height="90px">
<img src="https://api.dicebear.com/9.x/open-peeps/svg?seed=Luna" height="90px">
<img src="https://api.dicebear.com/9.x/open-peeps/svg?seed=Bobby" height="90px">
<img src="https://api.dicebear.com/9.x/open-peeps/svg?seed=Linda" height="90px">

## Initials

<img src="https://api.dicebear.com/9.x/initials/svg?seed=Jimmy" height="90px">
<img src="https://api.dicebear.com/9.x/initials/svg?seed=Luna" height="90px">
<img src="https://api.dicebear.com/9.x/initials/svg?seed=Bobby" height="90px">
<img src="https://api.dicebear.com/9.x/initials/svg?seed=Linda" height="90px">

## Usage

Extends [Bogus](https://github.com/bchavez/Bogus) to use DiceBear.Bogus.

```
dotnet add package DiceBear.Bogus
```

```
var faker = new Faker("en");

string avatarURL = faker.DiceBear.OpenPeeps();

```


## Credits

All work is down the amazing people at DiceBear, this library merely allows the use of the Avatars
with the Bogus libraries.


## Updates 04 - Aug - 2024

 - Added new DiceBear Collections
 - Added list of Collection Names