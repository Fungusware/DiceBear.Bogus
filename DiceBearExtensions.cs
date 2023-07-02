﻿using Bogus.Premium;

namespace Bogus
{
    public static  class DiceBearExtensions
    {

        public static DiceBear DiceBear(this Faker faker)
        {
            return ContextHelper.GetOrSet(faker, () => new DiceBear());
        }

        //public static string WaffleHtml(this Faker faker, int paragraphs = 1, bool includeHeading = true) =>
        //    faker.Waffle().Html(paragraphs, includeHeading);

        //public static string WaffleTitle(this Faker faker) =>
        //    faker.Waffle().Title();

        //public static string WaffleText(this Faker faker, int paragraphs = 1, bool includeHeading = true) =>
        //    faker.Waffle().Text(paragraphs, includeHeading);

        //public static string WaffleMarkdown(this Faker faker, int paragraphs = 1, bool includeHeading = true) =>
        //    faker.Waffle().Markdown(paragraphs, includeHeading);
    }
}
