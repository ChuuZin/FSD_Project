using FSDProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Configurations.Entities
{
    public class StoreItemSeed : IEntityTypeConfiguration<StoreItem>
    {
        public void Configure(EntityTypeBuilder<StoreItem> builder)
        {
            builder.HasData(
                new StoreItem
                {
                    StoreItemId = 1,
                    Questions = "How do you say 'How are you' in Hindi?",
                    // MultipleChoice = new string[] { "1. Kaise ho", "2. Kaise hai", "3. Aap kaise hai", "4. Tum kaise ho" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 3,
                    CourseDatabaseId = 4
                    
                },
                new StoreItem
                {
                    StoreItemId = 2,
                    Questions = "What does this sentence 'तुम किस विषय में रुचि रखते हो? ' mean?",
                    // MultipleChoice = new string[] { "1. Which subject are you interested in? ", "2. Do you work?", "3. What do you do for work?", "4. Where do you study?" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 1,
                    CourseDatabaseId = 4
                },
                new StoreItem
                {
                    StoreItemId = 3,
                    Questions = "What should you say infront of your parents when you greet them in a informal tone",
                    // MultipleChoice = new string[] { "1. नमस्ते माता-पिता जी।", "2. सुप्रभात, माँ-पापा।", "3. कैसे हो, माता-पिता जी?", "4. नमस्कार, माता-पिता!" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 2,
                    CourseDatabaseId = 4
                },
                new StoreItem
                {
                    StoreItemId = 4,
                    Questions = "'यह जगह कहाँ है?' means 'Where is this place?'. Is this true or false?",
                    // MultipleChoice = new string[] { "1. True", "2. False"},
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 1,
                    CourseDatabaseId = 4
                },
                new StoreItem
                {
                    StoreItemId = 5,
                    Questions = "Which word is a noun?",
                    // MultipleChoice = new string[] { "1. Run", "2. Beautiful", "3. Happiness", "4. Quickly" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 3,
                    CourseDatabaseId = 1

                },
                new StoreItem
                {
                    StoreItemId = 6,
                    Questions = "Which word is an adjective?",
                    // MultipleChoice = new string[] { "1. Red", "2. Jump", "3. Apple", "4. Slowly" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 1,
                    CourseDatabaseId = 1
                },
                new StoreItem
                {
                    StoreItemId = 7,
                    Questions = "Which sentence is grammatically correct?",
                    // MultipleChoice = new string[] { "1. She don’t like ice cream.", "2. He go to the park every morning", "3. They are playing soccer in the field", "4. The cat drinked all the milk" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 3,
                    CourseDatabaseId = 1
                },
                new StoreItem
                {
                    StoreItemId = 8,
                    Questions = "Which sentence uses 'their' correctly?",
                    // MultipleChoice = new string[] { "1. Their going to the park later today", "2. The dog wagged their tail happily", "3. She asked their to help with the project", "4. The students finished their homework before class" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 4,
                    CourseDatabaseId = 1
                },
                new StoreItem
                {
                    StoreItemId = 9,
                    Questions = "What does the Malay word 'Selamat' mean?",
                    // MultipleChoice = new string[] { "1. Goodbye", "2. Safe", "3. Fast", "4. Bright" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 2,
                    CourseDatabaseId = 3
                },
                new StoreItem
                {
                    StoreItemId = 10,
                    Questions = "What is the Malay word for 'Thank you'?",
                    // MultipleChoice = new string[] { "1. Selamat pagi", "2. Apa khabar", "3.  Sama-sama", "4. Terima kasih" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 4,
                    CourseDatabaseId = 3
                },
                new StoreItem
                {
                    StoreItemId = 11,
                    Questions = "Which malay sentence is correct when speaking to elders?",
                    // MultipleChoice = new string[] { "1. Apa khabar, kawan?", "2. Saya nak pergi rumah awak", "3. Eh, tolong bagi saya itu", "4. Bolehkah saya bantu anda?" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 4,
                    CourseDatabaseId = 3
                },
                new StoreItem
                {
                    StoreItemId = 12,
                    Questions = "Does this sentence 'Saya suka makan nasi lemak di waktu pag' mean ' I like to eat nasi lemak in the morning'?",
                    // MultipleChoice = new string[] { "1. True", "2. False" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 1,
                    CourseDatabaseId = 3
                },
                new StoreItem
                {
                    StoreItemId = 13,
                    Questions = "What is the Burmese word for 'water'?",
                    // MultipleChoice = new string[] { "1. ရေ (Yay)", "2. မီး (Mee)", "3. မြေ (Myay)", "4. လေ (Lay)" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 1,
                    CourseDatabaseId = 2
                },
                new StoreItem
                {
                    StoreItemId = 14,
                    Questions = "What does 'မင်္ဂလာပါ' mean?",
                    // MultipleChoice = new string[] { "1.Goodbye", "2. Hello", "3. Thank you", "4. Please" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 2,
                    CourseDatabaseId = 2
                },
                new StoreItem
                { 
                    StoreItemId = 15,
                    Questions = "Which word is a Burmese noun?",
                    // MultipleChoice = new string[] { "1. ကြည့်ရှု (Kyisu)", "2. သွား (Thwa)", "3. လှပ (Lhpa)", "4. ကျောင်း (Kyaung)" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 4,
                    CourseDatabaseId = 2
                },
                new StoreItem
                {
                    StoreItemId = 16,
                    Questions = "What is the plural form of 'ပန်းသီး' (apple) in Burmese?",
                    // MultipleChoice = new string[] { "1. ပန်း", "2. ပန်းသီး", "3. ပန်းသီးများ", "4. သီးများ" },
                    MultipleChoice = "1. Kaise ho, 2. Kaise hai, 3. Aap kaise hai, 4. Tum kaise ho",
                    Answer = 3,
                    CourseDatabaseId = 2
                }
            );
        }
    }
}
