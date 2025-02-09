﻿// <auto-generated />
using FSDProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FSDProject.Migrations
{
    [DbContext(typeof(FSDProjectContext))]
    partial class FSDProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FSDProject.Domain.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int?>("CompletionPercentage")
                        .HasColumnType("int");

                    b.Property<int>("CourseDatabaseId")
                        .HasColumnType("int");

                    b.Property<string>("CourseDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("CoursePrice")
                        .HasColumnType("real");

                    b.Property<int?>("ScoreId")
                        .HasColumnType("int");

                    b.Property<int?>("UserAccId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("CourseDatabaseId");

                    b.HasIndex("ScoreId");

                    b.HasIndex("UserAccId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CompletionPercentage = 0,
                            CourseDatabaseId = 1,
                            CourseDuration = "60 minutes",
                            CourseName = "English language course",
                            CoursePrice = 10.5f
                        },
                        new
                        {
                            CourseId = 2,
                            CompletionPercentage = 0,
                            CourseDatabaseId = 2,
                            CourseDuration = "90 minutes",
                            CourseName = "Burmese language course",
                            CoursePrice = 15f
                        },
                        new
                        {
                            CourseId = 3,
                            CompletionPercentage = 0,
                            CourseDatabaseId = 3,
                            CourseDuration = "50 minutes",
                            CourseName = "Malay language course",
                            CoursePrice = 8f
                        },
                        new
                        {
                            CourseId = 4,
                            CompletionPercentage = 0,
                            CourseDatabaseId = 4,
                            CourseDuration = "75 minutes",
                            CourseName = "Hindi language course",
                            CoursePrice = 12f
                        });
                });

            modelBuilder.Entity("FSDProject.Domain.CourseDatabase", b =>
                {
                    b.Property<int>("CourseDatabaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseDatabaseId"));

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseDatabaseId");

                    b.ToTable("CourseDatabase");

                    b.HasData(
                        new
                        {
                            CourseDatabaseId = 1,
                            LanguageName = "English"
                        },
                        new
                        {
                            CourseDatabaseId = 2,
                            LanguageName = "Burmese"
                        },
                        new
                        {
                            CourseDatabaseId = 3,
                            LanguageName = "Malay"
                        },
                        new
                        {
                            CourseDatabaseId = 4,
                            LanguageName = "Hindi"
                        });
                });

            modelBuilder.Entity("FSDProject.Domain.RewardShop", b =>
                {
                    b.Property<int>("RewardShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RewardShopId"));

                    b.Property<string>("PointCost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RewardType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RewardShopId");

                    b.ToTable("RewardShop");

                    b.HasData(
                        new
                        {
                            RewardShopId = 1,
                            PointCost = "500 points",
                            RewardType = "Monitor"
                        },
                        new
                        {
                            RewardShopId = 2,
                            PointCost = "450 points",
                            RewardType = "Microphone"
                        },
                        new
                        {
                            RewardShopId = 3,
                            PointCost = "1000 points",
                            RewardType = "Laptop"
                        },
                        new
                        {
                            RewardShopId = 4,
                            PointCost = "300 points",
                            RewardType = "PowerBank"
                        },
                        new
                        {
                            RewardShopId = 5,
                            PointCost = "600 points",
                            RewardType = "AppleWatch"
                        });
                });

            modelBuilder.Entity("FSDProject.Domain.Score", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreId"));

                    b.Property<int?>("PointsAwarded")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<int?>("StoreItemId")
                        .HasColumnType("int");

                    b.Property<int>("UserProfileId")
                        .HasColumnType("int");

                    b.HasKey("ScoreId");

                    b.HasIndex("StoreItemId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("FSDProject.Domain.StoreItem", b =>
                {
                    b.Property<int>("StoreItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreItemId"));

                    b.Property<int?>("Answer")
                        .HasColumnType("int");

                    b.Property<int>("CourseDatabaseId")
                        .HasColumnType("int");

                    b.Property<string>("MultipleChoice1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MultipleChoice2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MultipleChoice3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MultipleChoice4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Questions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreItemId");

                    b.HasIndex("CourseDatabaseId");

                    b.ToTable("StoreItem");

                    b.HasData(
                        new
                        {
                            StoreItemId = 1,
                            Answer = 3,
                            CourseDatabaseId = 4,
                            MultipleChoice1 = "1. Kaise ho",
                            MultipleChoice2 = "2. Kaise hai",
                            MultipleChoice3 = "3. Aap kaise hai",
                            MultipleChoice4 = "4. Tum kaise ho",
                            Questions = "How do you say 'How are you' in Hindi?"
                        },
                        new
                        {
                            StoreItemId = 2,
                            Answer = 1,
                            CourseDatabaseId = 4,
                            MultipleChoice1 = "1. Which subject are you interested in?",
                            MultipleChoice2 = "2. Do you work?",
                            MultipleChoice3 = "3. What do you do for work?",
                            MultipleChoice4 = "4. Where do you study?",
                            Questions = "What does this sentence 'tum kis vishay mein ruchi rakhate ho? ' mean?"
                        },
                        new
                        {
                            StoreItemId = 3,
                            Answer = 2,
                            CourseDatabaseId = 4,
                            MultipleChoice1 = "1. namaste maata-pita jee",
                            MultipleChoice2 = "2. suprabhaat, maan-paapa",
                            MultipleChoice3 = "3. kaise ho, maata-pita jee?",
                            MultipleChoice4 = "4. namaskaar, maata-pita!",
                            Questions = "What should you say infront of your parents when you greet them in a informal tone"
                        },
                        new
                        {
                            StoreItemId = 4,
                            Answer = 1,
                            CourseDatabaseId = 4,
                            MultipleChoice1 = "1. True",
                            MultipleChoice2 = "2. False",
                            MultipleChoice3 = "3. I don't know",
                            MultipleChoice4 = "4. Both",
                            Questions = "'yah jagah kahaan hai?' means 'Where is this place?'. Is this true or false?"
                        },
                        new
                        {
                            StoreItemId = 5,
                            Answer = 3,
                            CourseDatabaseId = 4,
                            MultipleChoice1 = "1. How old are you?",
                            MultipleChoice2 = "2. Where are you from?",
                            MultipleChoice3 = "3. What is your name?",
                            MultipleChoice4 = "4. What do you do?",
                            Questions = "What does 'aapaka naam kya hai?' mean in English?"
                        },
                        new
                        {
                            StoreItemId = 6,
                            Answer = 1,
                            CourseDatabaseId = 4,
                            MultipleChoice1 = "1. main achchha hoon",
                            MultipleChoice2 = "2. tum achchhe ho",
                            MultipleChoice3 = "3. ham achchhe hain",
                            MultipleChoice4 = "4. vah achchha hai",
                            Questions = "Which sentence means 'I am fine'?"
                        },
                        new
                        {
                            StoreItemId = 7,
                            Answer = 2,
                            CourseDatabaseId = 4,
                            MultipleChoice1 = "1. kalam",
                            MultipleChoice2 = "2. pustak ",
                            MultipleChoice3 = "3. zameen",
                            MultipleChoice4 = "4. desk",
                            Questions = "What is the Hindi word for 'book'?"
                        },
                        new
                        {
                            StoreItemId = 8,
                            Answer = 1,
                            CourseDatabaseId = 4,
                            MultipleChoice1 = "1. suprabhaat",
                            MultipleChoice2 = "2. shubh raatri",
                            MultipleChoice3 = "3. namaste",
                            MultipleChoice4 = "4. dhanyavaad",
                            Questions = "How do you say 'Good Night' in Hindi?"
                        },
                        new
                        {
                            StoreItemId = 9,
                            Answer = 1,
                            CourseDatabaseId = 1,
                            MultipleChoice1 = "1. Run",
                            MultipleChoice2 = "2. Quickly",
                            MultipleChoice3 = "3. Beautiful",
                            MultipleChoice4 = "4. Happiness",
                            Questions = "Which word is a verb?"
                        },
                        new
                        {
                            StoreItemId = 10,
                            Answer = 4,
                            CourseDatabaseId = 1,
                            MultipleChoice1 = "1. He",
                            MultipleChoice2 = "2. Runs",
                            MultipleChoice3 = "3. Very",
                            MultipleChoice4 = "4. Fast",
                            Questions = "Identify the adverb in this sentence: 'He runs very fast.'"
                        },
                        new
                        {
                            StoreItemId = 11,
                            Answer = 3,
                            CourseDatabaseId = 1,
                            MultipleChoice1 = "1. Goes",
                            MultipleChoice2 = "2. Gone",
                            MultipleChoice3 = "3. Went",
                            MultipleChoice4 = "4. Going",
                            Questions = "What is the past tense of 'go'?"
                        },
                        new
                        {
                            StoreItemId = 12,
                            Answer = 2,
                            CourseDatabaseId = 1,
                            MultipleChoice1 = "1. Your going to the park",
                            MultipleChoice2 = "2. Your book is on the table",
                            MultipleChoice3 = "3. She asked your to help",
                            MultipleChoice4 = "4. Their book is here",
                            Questions = "Which sentence uses 'your' correctly?"
                        },
                        new
                        {
                            StoreItemId = 13,
                            Answer = 3,
                            CourseDatabaseId = 1,
                            MultipleChoice1 = "1. Run ",
                            MultipleChoice2 = "2. Beautiful ",
                            MultipleChoice3 = "3.Happiness ",
                            MultipleChoice4 = "4. Quickly ",
                            Questions = "Which word is a noun?"
                        },
                        new
                        {
                            StoreItemId = 14,
                            Answer = 1,
                            CourseDatabaseId = 1,
                            MultipleChoice1 = "1. Red",
                            MultipleChoice2 = "2. Jump",
                            MultipleChoice3 = "3. Apple",
                            MultipleChoice4 = "4. Slowly",
                            Questions = "Which word is an adjective?"
                        },
                        new
                        {
                            StoreItemId = 15,
                            Answer = 3,
                            CourseDatabaseId = 1,
                            MultipleChoice1 = "1. She don’t like ice cream",
                            MultipleChoice2 = "2. He go to the park every morning",
                            MultipleChoice3 = "3. They are playing soccer in the field",
                            MultipleChoice4 = "4. The cat drinked all the milk",
                            Questions = "Which sentence is grammatically correct?"
                        },
                        new
                        {
                            StoreItemId = 16,
                            Answer = 4,
                            CourseDatabaseId = 1,
                            MultipleChoice1 = "1. Their going to the park later today",
                            MultipleChoice2 = "2. The dog wagged their tail happily",
                            MultipleChoice3 = "3. She asked their to help with the project",
                            MultipleChoice4 = "4. The students finished their homework before class?",
                            Questions = "Which sentence uses 'their' correctly?"
                        },
                        new
                        {
                            StoreItemId = 17,
                            Answer = 2,
                            CourseDatabaseId = 3,
                            MultipleChoice1 = "1. What is your name?",
                            MultipleChoice2 = "2. How are you?",
                            MultipleChoice3 = "3. Goodbye",
                            MultipleChoice4 = "4. Thank you",
                            Questions = "What does 'Apa khabar' mean in English?"
                        },
                        new
                        {
                            StoreItemId = 18,
                            Answer = 2,
                            CourseDatabaseId = 3,
                            MultipleChoice1 = "1. Rumah",
                            MultipleChoice2 = "2. Sekolah",
                            MultipleChoice3 = "3. Jalan",
                            MultipleChoice4 = "4. Buku",
                            Questions = "Which Malay word means 'School'?"
                        },
                        new
                        {
                            StoreItemId = 19,
                            Answer = 2,
                            CourseDatabaseId = 3,
                            MultipleChoice1 = "1. I am tired",
                            MultipleChoice2 = "2. I am hungry",
                            MultipleChoice3 = "3. I am happy",
                            MultipleChoice4 = "4. I am sad",
                            Questions = "Translate 'Saya lapar' into English."
                        },
                        new
                        {
                            StoreItemId = 20,
                            Answer = 3,
                            CourseDatabaseId = 3,
                            MultipleChoice1 = "1. Selamat pagi",
                            MultipleChoice2 = "2. Selamat malam",
                            MultipleChoice3 = "3. Selamat petang",
                            MultipleChoice4 = "4. Selamat siang",
                            Questions = "How do you say 'Good evening' in Malay?"
                        },
                        new
                        {
                            StoreItemId = 21,
                            Answer = 2,
                            CourseDatabaseId = 3,
                            MultipleChoice1 = "1. Goodbye",
                            MultipleChoice2 = "2. Safe",
                            MultipleChoice3 = "3. Fast",
                            MultipleChoice4 = "4. Bright",
                            Questions = "What does the Malay word 'Selamat' mean?"
                        },
                        new
                        {
                            StoreItemId = 22,
                            Answer = 4,
                            CourseDatabaseId = 3,
                            MultipleChoice1 = "1. Selamat pagi",
                            MultipleChoice2 = "2. Apa khaba",
                            MultipleChoice3 = "3. Sama-sama",
                            MultipleChoice4 = "4. Terima kasih",
                            Questions = "What is the Malay word for 'Thank you'?"
                        },
                        new
                        {
                            StoreItemId = 23,
                            Answer = 4,
                            CourseDatabaseId = 3,
                            MultipleChoice1 = "1. Apa khabar, kawan?",
                            MultipleChoice2 = "2. Saya nak pergi rumah awak",
                            MultipleChoice3 = "3. Eh, tolong bagi saya itu",
                            MultipleChoice4 = "4. Bolehkah saya bantu anda?",
                            Questions = "Which malay sentence is correct when speaking to elders?"
                        },
                        new
                        {
                            StoreItemId = 24,
                            Answer = 1,
                            CourseDatabaseId = 3,
                            MultipleChoice1 = "1. True",
                            MultipleChoice2 = "2. False",
                            MultipleChoice3 = "3. I dont know ",
                            MultipleChoice4 = "4. Both",
                            Questions = "Does this sentence 'Saya suka makan nasi lemak di waktu pag' mean ' I like to eat nasi lemak in the morning'?"
                        },
                        new
                        {
                            StoreItemId = 25,
                            Answer = 1,
                            CourseDatabaseId = 2,
                            MultipleChoice1 = "1. Brother",
                            MultipleChoice2 = "2. Sister",
                            MultipleChoice3 = "3. Uncle",
                            MultipleChoice4 = "4. Aunt",
                            Questions = "What does 'maung' mean in English?"
                        },
                        new
                        {
                            StoreItemId = 26,
                            Answer = 3,
                            CourseDatabaseId = 2,
                            MultipleChoice1 = "1. Welcome",
                            MultipleChoice2 = "2. Goodbye",
                            MultipleChoice3 = "3. Thank you",
                            MultipleChoice4 = "4. Excuse me",
                            Questions = "Translate kyaayyjuutainpartaa' into English."
                        },
                        new
                        {
                            StoreItemId = 27,
                            Answer = 2,
                            CourseDatabaseId = 2,
                            MultipleChoice1 = "1. nayaain",
                            MultipleChoice2 = "2. kyaungg",
                            MultipleChoice3 = "3. hcarr",
                            MultipleChoice4 = "4. ray",
                            Questions = "What is the Burmese word for 'School'?"
                        },
                        new
                        {
                            StoreItemId = 28,
                            Answer = 4,
                            CourseDatabaseId = 2,
                            MultipleChoice1 = "1. hotekae",
                            MultipleChoice2 = "2. larpar",
                            MultipleChoice3 = "3. maingalarpar",
                            MultipleChoice4 = "4. swarrtotmaal",
                            Questions = "How do you say 'Goodbye' in Burmese?"
                        },
                        new
                        {
                            StoreItemId = 29,
                            Answer = 1,
                            CourseDatabaseId = 2,
                            MultipleChoice1 = "1. Yay",
                            MultipleChoice2 = "2. Mee",
                            MultipleChoice3 = "3. Myay",
                            MultipleChoice4 = "4. Lay",
                            Questions = "What is the Burmese word for 'water'?"
                        },
                        new
                        {
                            StoreItemId = 30,
                            Answer = 2,
                            CourseDatabaseId = 2,
                            MultipleChoice1 = "1.Goodbye",
                            MultipleChoice2 = "2. Hello",
                            MultipleChoice3 = "3. Thank you",
                            MultipleChoice4 = "4. Please",
                            Questions = "What does 'maingalarpar' mean?"
                        },
                        new
                        {
                            StoreItemId = 31,
                            Answer = 4,
                            CourseDatabaseId = 2,
                            MultipleChoice1 = "1. Kyisu",
                            MultipleChoice2 = "2. Thwa",
                            MultipleChoice3 = "3. Lhpa",
                            MultipleChoice4 = "4. Kyaung",
                            Questions = "Which word is a Burmese noun?"
                        },
                        new
                        {
                            StoreItemId = 32,
                            Answer = 3,
                            CourseDatabaseId = 2,
                            MultipleChoice1 = "1. paann",
                            MultipleChoice2 = "2. paannsee myarr",
                            MultipleChoice3 = "3. paannsee",
                            MultipleChoice4 = "4. see myarr",
                            Questions = "Which of the folowing is correct for Apple in Burmese?"
                        });
                });

            modelBuilder.Entity("FSDProject.Domain.UserAcc", b =>
                {
                    b.Property<int>("UserAccId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserAccId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserAccId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("UserAcc");
                });

            modelBuilder.Entity("FSDProject.Domain.UserProfile", b =>
                {
                    b.Property<int>("UserProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserProfileId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("CurrentPoints")
                        .HasColumnType("int");

                    b.Property<int?>("RewardId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserProfileId");

                    b.HasIndex("CourseId");

                    b.HasIndex("RewardId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("FSDProject.Domain.Course", b =>
                {
                    b.HasOne("FSDProject.Domain.CourseDatabase", "CourseDatabase")
                        .WithMany()
                        .HasForeignKey("CourseDatabaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSDProject.Domain.Score", "Score")
                        .WithMany("Courses")
                        .HasForeignKey("ScoreId");

                    b.HasOne("FSDProject.Domain.UserAcc", "UserAcc")
                        .WithMany("Courses")
                        .HasForeignKey("UserAccId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CourseDatabase");

                    b.Navigation("Score");

                    b.Navigation("UserAcc");
                });

            modelBuilder.Entity("FSDProject.Domain.Score", b =>
                {
                    b.HasOne("FSDProject.Domain.StoreItem", "StoreItem")
                        .WithMany("Scores")
                        .HasForeignKey("StoreItemId");

                    b.HasOne("FSDProject.Domain.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StoreItem");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("FSDProject.Domain.StoreItem", b =>
                {
                    b.HasOne("FSDProject.Domain.CourseDatabase", "CourseDatabase")
                        .WithMany("StoreItems")
                        .HasForeignKey("CourseDatabaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseDatabase");
                });

            modelBuilder.Entity("FSDProject.Domain.UserAcc", b =>
                {
                    b.HasOne("FSDProject.Domain.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("FSDProject.Domain.UserProfile", b =>
                {
                    b.HasOne("FSDProject.Domain.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FSDProject.Domain.RewardShop", "Reward")
                        .WithMany("UserProfile")
                        .HasForeignKey("RewardId");

                    b.Navigation("Course");

                    b.Navigation("Reward");
                });

            modelBuilder.Entity("FSDProject.Domain.CourseDatabase", b =>
                {
                    b.Navigation("StoreItems");
                });

            modelBuilder.Entity("FSDProject.Domain.RewardShop", b =>
                {
                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("FSDProject.Domain.Score", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("FSDProject.Domain.StoreItem", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("FSDProject.Domain.UserAcc", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
