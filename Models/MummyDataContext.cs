using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace justTesting.Models
{
    public partial class MummyDataContext : DbContext
    {
        public MummyDataContext()
        {
        }
        public MummyDataContext(DbContextOptions<MummyDataContext> options)
    : base(options)
        {
        }

        public static MummyDataContext Create()
        {
            return new MummyDataContext();
        }


        public virtual DbSet<Arm> Arm { get; set; }
        public virtual DbSet<Burial> Burial { get; set; }
        public virtual DbSet<BurialSite> BurialSite { get; set; }
        public virtual DbSet<C14data> C14data { get; set; }
        public virtual DbSet<Head> Head { get; set; }
        public virtual DbSet<Hips> Hips { get; set; }
        public virtual DbSet<ItemTable> ItemTable { get; set; }
        public virtual DbSet<Leg> Leg { get; set; }
        public virtual DbSet<NewHairColor> NewHairColor { get; set; }
        public virtual DbSet<Samples> Samples { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-0VIEPM3T\\SQLEXPRESS;Initial Catalog=MummyData;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arm>(entity =>
            {
                entity.HasKey(e => e.OurId);

                entity.Property(e => e.OurId)
                    .HasColumnName("OurID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Humerus).HasColumnName("humerus");

                entity.Property(e => e.HumerusHead).HasColumnName("humerus_head");

                entity.Property(e => e.HumerusLength).HasColumnName("humerus_length");

                entity.Property(e => e.MedialClavicle).HasColumnName("medial_clavicle");
            });

            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.HasKey(e => e.OurID);

                entity.Property(e => e.OurID)
                    .HasColumnName("PicId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OurID).HasColumnName("OurID");

                entity.Property(e => e.PicId).HasColumnName("PicId");

                entity.Property(e => e.PicUrl).HasColumnName("PicUrl");
                entity.Property(e => e.Type).HasColumnName("Type");

            });



            modelBuilder.Entity<Burial>(entity =>
            {
                entity.HasKey(e => e.OurId);

                entity.HasIndex(e => e.OurId)
                    .HasName("IX_Burial")
                    .IsUnique();

                entity.Property(e => e.OurId)
                    .HasColumnName("Our_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgeCategory)
                    .HasColumnName("Age_Category")
                    .HasMaxLength(50);

                entity.Property(e => e.AgeMethod).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.ArtifactFound)
                    .HasColumnName("artifact_found")
                    .HasMaxLength(50);

                entity.Property(e => e.ArtifactsDescription)
                    .HasColumnName("artifacts_description")
                    .HasMaxLength(150);

                entity.Property(e => e.BodyAnalysis)
                    .HasColumnName("body_analysis")
                    .HasMaxLength(50);

                entity.Property(e => e.BoneTaken)
                    .HasColumnName("bone_taken")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialArtifactDescription)
                    .HasColumnName("Burial_Artifact_Description")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialDepthMeters)
                    .HasColumnName("burial_depth_meters")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BurialId)
                    .HasColumnName("Burial_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialLengthMeters)
                    .HasColumnName("burial_length_meters")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnName("burial_location_EW")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnName("burial_location_NS")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialNumber)
                    .HasColumnName("burial_number")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialPreservation)
                    .HasColumnName("burial_preservation")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialSiteId)
                    .HasColumnName("Burial_Site_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialSituation).HasColumnName("burial_situation");

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(50);

                entity.Property(e => e.BurialWrapping)
                    .HasColumnName("burial_wrapping")
                    .HasMaxLength(50);

                entity.Property(e => e.BuriedWithArtifacts)
                    .HasColumnName("Buried_with_Artifacts")
                    .HasMaxLength(50);

                entity.Property(e => e.ByuHasSample)
                    .HasColumnName("BYU_has_sample")
                    .HasMaxLength(50);

                entity.Property(e => e.Cluster).HasMaxLength(50);

                entity.Property(e => e.DayFound)
                    .HasColumnName("day_found")
                    .HasMaxLength(50);

                entity.Property(e => e.DescriptionOfTaken)
                    .HasColumnName("description_of_taken")
                    .HasMaxLength(100);

                entity.Property(e => e.EpiphysealUnion)
                    .HasColumnName("epiphyseal_union")
                    .HasMaxLength(50);

                entity.Property(e => e.EstimateAge)
                    .HasColumnName("estimate_age")
                    .HasMaxLength(50);

                entity.Property(e => e.EstimateLivingStature)
                    .HasColumnName("estimate_living_stature")
                    .HasMaxLength(50);

                entity.Property(e => e.FaceBundle)
                    .HasColumnName("face_bundle")
                    .HasMaxLength(100);

                entity.Property(e => e.FieldBook)
                    .HasColumnName("field_book")
                    .HasMaxLength(50);

                entity.Property(e => e.FieldBookNotes).HasColumnName("Field_Book_Notes");

                entity.Property(e => e.FieldBookPageNumber)
                    .HasColumnName("Field_Book_Page_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.Gamous).HasMaxLength(50);

                entity.Property(e => e.GeFunctionTotal)
                    .HasColumnName("GE_function_total")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderBodyCol)
                    .HasColumnName("gender_body_col")
                    .HasMaxLength(50);

                entity.Property(e => e.GenderGe)
                    .HasColumnName("gender_GE")
                    .HasMaxLength(50);

                entity.Property(e => e.HairColor)
                    .HasColumnName("hair_color")
                    .HasMaxLength(50);

                entity.Property(e => e.HairTaken)
                    .HasColumnName("hair_taken")
                    .HasMaxLength(50);

                entity.Property(e => e.HeadDirection)
                    .HasColumnName("head_direction")
                    .HasMaxLength(50);

                entity.Property(e => e.HighPairEw)
                    .HasColumnName("high_pair_EW")
                    .HasMaxLength(50);

                entity.Property(e => e.HighPairNs)
                    .HasColumnName("high_pair_NS")
                    .HasMaxLength(50);

                entity.Property(e => e.LinearHypoplasiaEnamel)
                    .HasColumnName("Linear_Hypoplasia_Enamel")
                    .HasMaxLength(100);

                entity.Property(e => e.LowPairEw)
                    .HasColumnName("low_pair_EW")
                    .HasMaxLength(50);

                entity.Property(e => e.LowPairNs)
                    .HasColumnName("low_pair_NS")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthFound)
                    .HasColumnName("month_found")
                    .HasMaxLength(50);

                entity.Property(e => e.OsteologyNotes)
                    .HasColumnName("Osteology_Notes")
                    .HasMaxLength(200);

                entity.Property(e => e.OsteologyUnknownComment)
                    .HasColumnName("osteology_unknown_comment")
                    .HasMaxLength(100);

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasMaxLength(50);

                entity.Property(e => e.PathologyAnomalies)
                    .HasColumnName("pathology_anomalies")
                    .HasMaxLength(200);

                entity.Property(e => e.PostcraniaAtMagazine)
                    .HasColumnName("Postcrania_at_Magazine")
                    .HasMaxLength(100);

                entity.Property(e => e.PostcraniaTrauma)
                    .HasColumnName("Postcrania_Trauma")
                    .HasMaxLength(100);

                entity.Property(e => e.PreservationIndex)
                    .HasColumnName("preservation_index")
                    .HasMaxLength(50);

                entity.Property(e => e.Rack).HasMaxLength(50);

                entity.Property(e => e.Robust)
                    .HasColumnName("robust")
                    .HasMaxLength(50);

                entity.Property(e => e.SampleNumber)
                    .HasColumnName("sample_number")
                    .HasMaxLength(50);

                entity.Property(e => e.SampleTaken)
                    .HasColumnName("Sample_Taken")
                    .HasMaxLength(50);

                entity.Property(e => e.SexMethod).HasMaxLength(50);

                entity.Property(e => e.Shelf).HasMaxLength(50);

                entity.Property(e => e.SoftTissueTaken)
                    .HasColumnName("soft_tissue_taken")
                    .HasMaxLength(50);

                entity.Property(e => e.SouthToFeet)
                    .HasColumnName("south_to_feet")
                    .HasMaxLength(50);

                entity.Property(e => e.SouthToHead)
                    .HasColumnName("south_to_head")
                    .HasMaxLength(50);

                entity.Property(e => e.TemporalMandibularJointOsteoarthritisTmjOa)
                    .HasColumnName("Temporal_Mandibular_Joint_Osteoarthritis_TMJ_OA")
                    .HasMaxLength(100);

                entity.Property(e => e.TextileTaken)
                    .HasColumnName("textile_taken")
                    .HasMaxLength(50);

                entity.Property(e => e.Tomb).HasMaxLength(100);

                entity.Property(e => e.ToothAttrition)
                    .HasColumnName("tooth_attrition")
                    .HasMaxLength(50);

                entity.Property(e => e.ToothEruption)
                    .HasColumnName("tooth_eruption")
                    .HasMaxLength(50);

                entity.Property(e => e.ToothTaken)
                    .HasColumnName("tooth_taken")
                    .HasMaxLength(50);

                entity.Property(e => e.WestToFeet)
                    .HasColumnName("west_to_feet")
                    .HasMaxLength(50);

                entity.Property(e => e.WestToHeadMeters)
                    .HasColumnName("west_to_head_Meters")
                    .HasMaxLength(50);

                entity.Property(e => e.YearFound)
                    .HasColumnName("year_found")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BurialSite>(entity =>
            {
                entity.Property(e => e.BurialSiteId)
                    .HasColumnName("Burial_Site_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Ew)
                    .HasColumnName("EW")
                    .HasMaxLength(50);

                entity.Property(e => e.Ewhigh).HasColumnName("EWHigh");

                entity.Property(e => e.Ewlow)
                    .HasColumnName("EWLow")
                    .HasMaxLength(50);

                entity.Property(e => e.Ns)
                    .HasColumnName("NS")
                    .HasMaxLength(50);

                entity.Property(e => e.Nshigh).HasColumnName("NSHigh");

                entity.Property(e => e.Nslow).HasColumnName("NSLow");

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasColumnName("SiteID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<C14data>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("C14Data");

                entity.Property(e => e.AdBc)
                    .HasColumnName("AD_BC")
                    .HasMaxLength(50);

                entity.Property(e => e.AdBc2)
                    .HasColumnName("AD_BC2")
                    .HasMaxLength(50);

                entity.Property(e => e.AdBc3)
                    .HasColumnName("AD_BC3")
                    .HasMaxLength(50);

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasMaxLength(50);

                entity.Property(e => e.Burial).HasMaxLength(50);

                entity.Property(e => e.BurialId)
                    .HasColumnName("Burial_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.C14Sample2017)
                    .HasColumnName("C14_Sample_2017")
                    .HasMaxLength(50);

                entity.Property(e => e.Calibrated95CalendarDateAvg)
                    .HasColumnName("Calibrated_95_Calendar_Date_AVG")
                    .HasMaxLength(50);

                entity.Property(e => e.Calibrated95CalendarDateMax).HasColumnName("Calibrated_95_Calendar_Date_MAX");

                entity.Property(e => e.Calibrated95CalendarDateMax2).HasColumnName("Calibrated_95_Calendar_Date_MAX2");

                entity.Property(e => e.Calibrated95CalendarDateMin).HasColumnName("Calibrated_95_Calendar_Date_MIN");

                entity.Property(e => e.Calibrated95CalendarDateMin2).HasColumnName("Calibrated_95_Calendar_Date_MIN2");

                entity.Property(e => e.Calibrated95CalendarDateSpan).HasColumnName("Calibrated_95_Calendar_Date_SPAN");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Column19)
                    .HasColumnName("column19")
                    .HasMaxLength(50);

                entity.Property(e => e.Conventional14cAgeBp).HasColumnName("Conventional_14C_age_BP");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.EW)
                    .HasColumnName("E_W")
                    .HasMaxLength(50);

                entity.Property(e => e.Foci).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.LowerEastWest)
                    .HasColumnName("Lower_East_West")
                    .HasMaxLength(50);

                entity.Property(e => e.LowerNS).HasColumnName("Lower_N_S");

                entity.Property(e => e.NS)
                    .HasColumnName("N_S")
                    .HasMaxLength(50);

                entity.Property(e => e.QuestionS)
                    .HasColumnName("Question_s")
                    .HasMaxLength(150);

                entity.Property(e => e.SizeMl).HasColumnName("Size_ml");

                entity.Property(e => e.Square).HasMaxLength(50);

                entity.Property(e => e.Tube)
                    .HasColumnName("TUBE")
                    .HasMaxLength(50);

                entity.Property(e => e.UpperEastWest).HasColumnName("Upper_East_West");

                entity.Property(e => e.UpperNS).HasColumnName("Upper_N_s");

                entity.Property(e => e._14cCalendarDate).HasColumnName("_14C_Calendar_Date");

                entity.Property(e => e._14cCalendarDatePositive).HasColumnName("_14C_Calendar_Date_Positive");
            });

            modelBuilder.Entity<Head>(entity =>
            {
                entity.HasKey(e => e.OurId);

                entity.Property(e => e.OurId)
                    .HasColumnName("OurID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgeSkull2018)
                    .HasColumnName("Age_Skull_2018")
                    .HasMaxLength(50);

                entity.Property(e => e.BasilarSuture)
                    .HasColumnName("basilar_suture")
                    .HasMaxLength(50);

                entity.Property(e => e.BasionBregmaHeight)
                    .HasColumnName("basion_bregma_height")
                    .HasMaxLength(50);

                entity.Property(e => e.BasionNasion)
                    .HasColumnName("basion_nasion")
                    .HasMaxLength(50);

                entity.Property(e => e.BasionProsthionLength)
                    .HasColumnName("basion_prosthion_length")
                    .HasMaxLength(50);

                entity.Property(e => e.BizygomaticDiameter)
                    .HasColumnName("bizygomatic_diameter")
                    .HasMaxLength(50);

                entity.Property(e => e.ButtonOsteoma)
                    .HasColumnName("Button_Osteoma")
                    .HasMaxLength(50);

                entity.Property(e => e.CranialSuture)
                    .HasColumnName("cranial_suture")
                    .HasMaxLength(50);

                entity.Property(e => e.CribraOrbitala)
                    .HasColumnName("Cribra_Orbitala")
                    .HasMaxLength(50);

                entity.Property(e => e.DateOnSkull)
                    .HasColumnName("Date_on_Skull")
                    .HasMaxLength(50);

                entity.Property(e => e.ForemanMagnum)
                    .HasColumnName("foreman_magnum")
                    .HasMaxLength(50);

                entity.Property(e => e.Gonian)
                    .HasColumnName("gonian")
                    .HasMaxLength(50);

                entity.Property(e => e.InterorbitalBreadth)
                    .HasColumnName("interorbital_breadth")
                    .HasMaxLength(50);

                entity.Property(e => e.MaximumCranialBreadth)
                    .HasColumnName("maximum_cranial_breadth")
                    .HasMaxLength(50);

                entity.Property(e => e.MaximumCranialLength)
                    .HasColumnName("maximum_cranial_length")
                    .HasMaxLength(50);

                entity.Property(e => e.MaximumNasalBreadth)
                    .HasColumnName("maximum_nasal_breadth")
                    .HasMaxLength(50);

                entity.Property(e => e.MetopicSuture)
                    .HasColumnName("Metopic_Suture")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthOnSkull)
                    .HasColumnName("Month_on_skull")
                    .HasMaxLength(50);

                entity.Property(e => e.NasionProsthion)
                    .HasColumnName("nasion_prosthion")
                    .HasMaxLength(50);

                entity.Property(e => e.NuchalCrest)
                    .HasColumnName("nuchal_crest")
                    .HasMaxLength(50);

                entity.Property(e => e.OrbitEdge)
                    .HasColumnName("orbit_edge")
                    .HasMaxLength(50);

                entity.Property(e => e.ParietalBossing)
                    .HasColumnName("parietal_bossing")
                    .HasMaxLength(50);

                entity.Property(e => e.PoroticHyperostosis)
                    .HasColumnName("Porotic_Hyperostosis")
                    .HasMaxLength(50);

                entity.Property(e => e.PoroticHyperostosisLocations)
                    .HasColumnName("Porotic_Hyperostosis_LOCATIONS")
                    .HasMaxLength(50);

                entity.Property(e => e.SexSkull2018)
                    .HasColumnName("Sex_Skull_2018")
                    .HasMaxLength(50);

                entity.Property(e => e.SkullAtMagazine)
                    .HasColumnName("Skull_at_Magazine")
                    .HasMaxLength(50);

                entity.Property(e => e.SkullTrauma)
                    .HasColumnName("Skull_Trauma")
                    .HasMaxLength(50);

                entity.Property(e => e.SupraorbitalRidges)
                    .HasColumnName("supraorbital_ridges")
                    .HasMaxLength(50);

                entity.Property(e => e.ToBeConfirmed)
                    .HasColumnName("TO_BE_CONFIRMED")
                    .HasMaxLength(50);

                entity.Property(e => e.YearOnSkull)
                    .HasColumnName("Year_on_skull")
                    .HasMaxLength(50);

                entity.Property(e => e.ZygomaticCrest)
                    .HasColumnName("zygomatic_crest")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hips>(entity =>
            {
                entity.HasKey(e => e.OurId);

                entity.Property(e => e.OurId)
                    .HasColumnName("OurID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DorsalPitting)
                    .HasColumnName("dorsal_pitting")
                    .HasMaxLength(50);

                entity.Property(e => e.IliacCrest)
                    .HasColumnName("iliac_crest")
                    .HasMaxLength(50);

                entity.Property(e => e.MedialIpRamus)
                    .HasColumnName("medial_IP_ramus")
                    .HasMaxLength(50);

                entity.Property(e => e.PreaurSulcus)
                    .HasColumnName("preaur_sulcus")
                    .HasMaxLength(50);

                entity.Property(e => e.PubicBone)
                    .HasColumnName("pubic_bone")
                    .HasMaxLength(50);

                entity.Property(e => e.PubicSymphysis)
                    .HasColumnName("pubic_symphysis")
                    .HasMaxLength(50);

                entity.Property(e => e.SciaticNotch)
                    .HasColumnName("sciatic_notch")
                    .HasMaxLength(50);

                entity.Property(e => e.SubpubicAngle)
                    .HasColumnName("subpubic_angle")
                    .HasMaxLength(50);

                entity.Property(e => e.VentralArc)
                    .HasColumnName("ventral_arc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BurialId).HasColumnName("BurialID");

                entity.Property(e => e.BurialNumber).HasMaxLength(50);

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasColumnName("ItemID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Leg>(entity =>
            {
                entity.HasKey(e => e.OurId);

                entity.Property(e => e.OurId)
                    .HasColumnName("OurID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FemurDiameter)
                    .HasColumnName("femur_diameter")
                    .HasMaxLength(50);

                entity.Property(e => e.FemurHead).HasColumnName("femur_head");

                entity.Property(e => e.FemurLength)
                    .HasColumnName("femur_length")
                    .HasMaxLength(50);

                entity.Property(e => e.TibiaLength)
                    .HasColumnName("tibia_length")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NewHairColor>(entity =>
            {
                entity.HasKey(e => e.HairId)
                    .HasName("PK__NewHairC__29636C0807B02B9D");

                entity.Property(e => e.HairId)
                    .HasColumnName("HairID")
                    .HasMaxLength(50);

                entity.Property(e => e.HairColor)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Samples>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.Burial).HasMaxLength(50);

                entity.Property(e => e.BurialId)
                    .IsRequired()
                    .HasColumnName("Burial_ID");

                entity.Property(e => e.Cluster).HasMaxLength(50);

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.EW)
                    .HasColumnName("E_W")
                    .HasMaxLength(50);

                entity.Property(e => e.High).HasMaxLength(50);

                entity.Property(e => e.High2)
                    .HasColumnName("High_2")
                    .HasMaxLength(50);

                entity.Property(e => e.Initials).HasMaxLength(50);

                entity.Property(e => e.Low).HasMaxLength(50);

                entity.Property(e => e.Low2)
                    .HasColumnName("Low_2")
                    .HasMaxLength(50);

                entity.Property(e => e.NS)
                    .HasColumnName("N_S")
                    .HasMaxLength(50);

                entity.Property(e => e.PreviouslySampled).HasColumnName("Previously_Sampled");

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
