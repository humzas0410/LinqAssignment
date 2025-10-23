﻿using System.Text.Json;

// deserialize mario json from file into List<Mario>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);

// display all characters
// foreach(Character character in characters)
// {
//   Console.WriteLine(character.Display());
// }
Console.Clear();

// display first character
// Console.WriteLine(characters.First().Display());

// display the first 5 characters
// foreach(Character character in characters.Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display every character except the first 5
// foreach(Character character in characters.Skip(5))
// {
//   Console.WriteLine(character.Display());
// }

// display characters 6-10
// foreach(Character character in characters.Skip(5).Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display last character
// Console.WriteLine(characters.Last().Display());

// first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));

// oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());

// are there any characters created in 1995?
// bool Character1995 = characters.Any(c => c.YearCreated == 1995);
// Console.WriteLine($"Are there characters created in 1995: {Character1995}");
// how many characters were created in 1995
// Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");
// which characters were created in 1995
// foreach (Character character in characters.Where(c => c.YearCreated == 1995))
// {
//    Console.WriteLine(character.Display());
// }
// which characters were created in 1995 (name only)
// foreach(Character character in characters.Where(c => c.YearCreated == 1995))
// {  
//     Console.WriteLine(character.Name);
// }
// Using only data needed
// foreach (String? name in characters.Where(c => c.YearCreated == 1995).Select(c => c.Name))
// {
//     Console.WriteLine(name);
// }
// which characters were created in 1995 (name & description only)
//foreach(var obj in characters.Where(c => c.YearCreated == 1995).Select(c => new { c.Name, c.Description }))
// foreach(var obj in characters.Where(c => c.YearCreated == 1995).Select(c => new { c.Name, c.Description }).OrderBy(c => c.Name))
// {
//      Console.WriteLine($"{obj.Name} - {obj.Description}"); 
// }
// foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO{ Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
// {
//   Console.WriteLine(characterDTO.Display());
// }

// how many characters in total (all series)?
// int CharacterCount = characters.Count();
// Console.WriteLine($"There are {CharacterCount} characters in all series");
// how many characters appear in the Mario series?
// int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
//Console.WriteLine($"There are {MarioCount} characters in the Mario series");
// how many characters appear in the Donkey Kong series?
// int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
// Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
// how many characters appear in the Mario & Donkey Kong series?
// int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");
// which characters (name only) appear in Mario and Donkey Kong?
// foreach (String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//     Console.WriteLine($"\t{name}");
// }
// how many characters appear in Donkey Kong and not in Mario?
// int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");
// which character(s) has/have the most alias's?
// foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
//   Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
// }

// how many letters make up the longest character name(s)
// int LengthOfName = characters.Max(c => c.Name!.Length);
// Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");
// which characters have the longest name?
// foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }

// all characters grouped by year created
// var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
// foreach(var characterByYearCreated in CharactersByYearCreated)
// {
//     Console.WriteLine(characterByYearCreated.Key);
//     foreach (var character in characterByYearCreated)
//     {
//         Console.WriteLine($"\t{character.Name}");
//     }  
// }

// 1.19a - How many character(s) were created in 1981 (all series)?
// int countCreated1981All = characters.Count(c => c.YearCreated == 1981);
// Console.WriteLine($"Characters created in 1981 (all series): {countCreated1981All}");

// 1.19b - List the character(s) created in 1981 (all series) - return character name and series only.
// foreach (var obj in characters
//     .Where(c => c.YearCreated == 1981)
//     .Select(c => new { c.Name, c.Series })
//     .OrderBy(c => c.Name))
// {
//     Console.WriteLine($"{obj.Name} - {string.Join(", ", obj.Series)}");
// }

// [1.19c] Count characters created in 1981 (Mario)
// int countCreated1981Mario = characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario")).Count();
// Console.WriteLine($"[1.19c] Count characters created in 1981 (Mario): {countCreated1981Mario}");

// [1.19d] List the character(s) created in 1981 (Mario series) - return character name only.
// foreach (string? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario")).Select(c => c.Name).OrderBy(n => n))
// {
//     Console.WriteLine($"[1.19d] {name}");
// }

// [1.19e] Count characters created in 1981 (Donkey Kong)
// int countCreated1981Dk = characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")).Count();
// Console.WriteLine($"[1.19e] Count characters created in 1981 (Donkey Kong): {countCreated1981Dk}");

// [1.19f] List the character(s) created in 1981 (Donkey Kong series) - return character name only.
// foreach (string? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")).Select(c => c.Name).OrderBy(n => n))
// {
//     Console.WriteLine($"[1.19f] {name}");
// }

// [1.20a] How many character(s) made their first appearance in Donkey Kong 64?
// int countFirstAppearDK64 = characters.Where(c => c.FirstAppearance == "Donkey Kong 64").Count();
// Console.WriteLine($"[1.20a] Characters that first appeared in Donkey Kong 64: {countFirstAppearDK64}");

// [1.20b] List the character(s) that made their first appearance in Donkey Kong 64 - return character name only.
// foreach (string? name in characters.Where(c => c.FirstAppearance == "Donkey Kong 64").Select(c => c.Name).OrderBy(n => n))
// {
//     Console.WriteLine($"[1.20b] {name}");
// }

// [1.21a] Are there any character(s) with no alias (all series)?
// bool anyNoAliasAll = characters.Any(c => c.Alias == null || c.Alias.Count == 0);
// Console.WriteLine($"[1.21a] Any characters with no alias (all series): {anyNoAliasAll}");

// [1.21b] How many character(s) have no alias (all series)?
// int countNoAliasAll = characters.Count(c => c.Alias == null || c.Alias.Count == 0);
// Console.WriteLine($"[1.21b] Characters with no alias (all series): {countNoAliasAll}");

// [1.21c] List the character(s) with no alias (all series) - return name, alias (or 'None'), and series.
// foreach (var obj in characters
//     .Where(c => c.Alias == null || c.Alias.Count == 0)
//     .Select(c => new { c.Name, Alias = c.Alias, c.Series })
//     .OrderBy(o => o.Name))
// {
//     string aliases = (obj.Alias == null || obj.Alias.Count == 0) ? "None" : string.Join(", ", obj.Alias);
//     Console.WriteLine($"[1.21c] {obj.Name} - Aliases: {aliases} - Series: {string.Join(", ", obj.Series)}");
// }

// [1.21d] Are there any character(s) with no alias in the Mario series?
// bool anyNoAliasMario = characters.Where(c => c.Series.Contains("Mario")).Any(c => c.Alias == null || c.Alias.Count == 0);
// Console.WriteLine($"[1.21d] Any characters with no alias (Mario): {anyNoAliasMario}");

// [1.21e] How many character(s) in the Mario series have no alias?
// int countNoAliasMario = characters.Where(c => c.Series.Contains("Mario")).Count(c => c.Alias == null || c.Alias.Count == 0);
// Console.WriteLine($"[1.21e] Characters with no alias (Mario): {countNoAliasMario}");

// [1.21f] List the character(s) in the Mario series with no alias - return Name and Alias (or 'None').
// foreach (var obj in characters
//     .Where(c => c.Series.Contains("Mario") && (c.Alias == null || c.Alias.Count == 0))
//     .Select(c => new { c.Name, Alias = c.Alias })
//     .OrderBy(o => o.Name))
// {
//     string aliases = (obj.Alias == null || obj.Alias.Count == 0) ? "None" : string.Join(", ", obj.Alias);
//     Console.WriteLine($"[1.21f] {obj.Name} - Aliases: {aliases}");
// }

// [1.21g] Are there any character(s) with no alias in the Donkey Kong series?
// bool anyNoAliasDk = characters.Where(c => c.Series.Contains("Donkey Kong")).Any(c => c.Alias == null || c.Alias.Count == 0);
// Console.WriteLine($"[1.21g] Any characters with no alias (Donkey Kong): {anyNoAliasDk}");

// [1.21h] How many character(s) in the Donkey Kong series have no alias?
// int countNoAliasDk = characters.Where(c => c.Series.Contains("Donkey Kong")).Count(c => c.Alias == null || c.Alias.Count == 0);
// Console.WriteLine($"[1.21h] Characters with no alias (Donkey Kong): {countNoAliasDk}");

// [1.21i] List the character(s) in the Donkey Kong series with no alias - return Name and Alias (or 'None').
// foreach (var obj in characters
//     .Where(c => c.Series.Contains("Donkey Kong") && (c.Alias == null || c.Alias.Count == 0))
//     .Select(c => new { c.Name, Alias = c.Alias })
//     .OrderBy(o => o.Name))
// {
//     string aliases = (obj.Alias == null || obj.Alias.Count == 0) ? "None" : string.Join(", ", obj.Alias);
//     Console.WriteLine($"[1.21i] {obj.Name} - Aliases: {aliases}");
// }

// [1.22a] Is there any character whose alias is 'Snowmad King'?
// bool anySnowmadKing = characters.Any(c => c.Alias != null && c.Alias.Contains("Snowmad King"));
// Console.WriteLine($"[1.22a] Any character with alias 'Snowmad King': {anySnowmadKing}");

// [1.22b] List characters whose alias is 'Snowmad King' - return Name and Alias.
// foreach (var obj in characters
//     .Where(c => c.Alias != null && c.Alias.Contains("Snowmad King"))
//     .Select(c => new { c.Name, Alias = c.Alias })
//     .OrderBy(o => o.Name))
// {
//     Console.WriteLine($"[1.22b] {obj.Name} - Aliases: {string.Join(", ", obj.Alias)}");
// }

// [1.23a] Is there any character whose alias is 'Winter Kong'?
// bool anyWinterKong = characters.Any(c => c.Alias != null && c.Alias.Contains("Winter Kong"));
// Console.WriteLine($"[1.23a] Any character with alias 'Winter Kong': {anyWinterKong}");

// [1.23b] List characters whose alias is 'Winter Kong' - return Name and Alias.
// foreach (var obj in characters
//     .Where(c => c.Alias != null && c.Alias.Contains("Winter Kong"))
//     .Select(c => new { c.Name, Alias = c.Alias })
//     .OrderBy(o => o.Name))
// {
//     Console.WriteLine($"[1.23b] {obj.Name} - Aliases: {string.Join(", ", obj.Alias)}");
// }

// [1.24a] How many characters have species 'Kremling'?
// int countKremling = characters.Count(c => c.Species == "Kremling");
// Console.WriteLine($"[1.24a] Characters with species 'Kremling': {countKremling}");

// [1.24b] List characters with species 'Kremling' - return Name only.
// foreach (string? name in characters.Where(c => c.Species == "Kremling").Select(c => c.Name).OrderBy(n => n))
// {
//     Console.WriteLine($"[1.24b] {name}");
// }

// [1.25a] How many characters in the Mario series have species 'Human'?
// int countMarioHuman = characters.Where(c => c.Series.Contains("Mario")).Count(c => c.Species == "Human");
// Console.WriteLine($"[1.25a] Mario-series characters with species 'Human': {countMarioHuman}");

// [1.25b] List Mario-series characters with species 'Human' - return Name only.
// foreach (string? name in characters
//     .Where(c => c.Series.Contains("Mario") && c.Species == "Human")
//     .Select(c => c.Name)
//     .OrderBy(n => n))
// {
//     Console.WriteLine($"[1.25b] {name}");
// }

// [1.25c] How many characters in the Mario series have species 'Koopa'?
int countMarioKoopa = characters.Where(c => c.Series.Contains("Mario")).Count(c => c.Species == "Koopa");
Console.WriteLine($"[1.25c] Mario-series characters with species 'Koopa': {countMarioKoopa}");