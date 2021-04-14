USE [master]
GO
Drop DataBase 
/****** Object:  Database [MummyData]    Script Date: 4/12/2021 8:40:27 PM ******/
CREATE DATABASE [MummyData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MummyData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MummyData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MummyData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MummyData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MummyData] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MummyData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MummyData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MummyData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MummyData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MummyData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MummyData] SET ARITHABORT OFF 
GO
ALTER DATABASE [MummyData] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MummyData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MummyData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MummyData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MummyData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MummyData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MummyData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MummyData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MummyData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MummyData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MummyData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MummyData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MummyData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MummyData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MummyData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MummyData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MummyData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MummyData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MummyData] SET  MULTI_USER 
GO
ALTER DATABASE [MummyData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MummyData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MummyData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MummyData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MummyData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MummyData] SET QUERY_STORE = OFF
GO
USE [MummyData]
GO
/****** Object:  Table [dbo].[Arm]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arm](
	[OurID] [int] NOT NULL,
	[humerus_head] [float] NULL,
	[medial_clavicle] [float] NULL,
	[humerus] [float] NULL,
	[humerus_length] [float] NULL,
 CONSTRAINT [PK_Arm] PRIMARY KEY CLUSTERED 
(
	[OurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Burial]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Burial](
	[Burial_ID] [nvarchar](50) NULL,
	[Our_ID] [int] NOT NULL,
	[Burial_Site_ID] [nvarchar](50) NULL,
	[burial_location_NS] [nvarchar](50) NULL,
	[burial_location_EW] [nvarchar](50) NULL,
	[low_pair_NS] [nvarchar](50) NULL,
	[high_pair_NS] [nvarchar](50) NULL,
	[low_pair_EW] [nvarchar](50) NULL,
	[high_pair_EW] [nvarchar](50) NULL,
	[burial_subplot] [nvarchar](50) NULL,
	[burial_depth_meters] [decimal](18, 0) NULL,
	[south_to_head] [nvarchar](50) NULL,
	[south_to_feet] [nvarchar](50) NULL,
	[west_to_head_Meters] [nvarchar](50) NULL,
	[west_to_feet] [nvarchar](50) NULL,
	[face_bundle] [nvarchar](100) NULL,
	[burial_wrapping] [nvarchar](50) NULL,
	[burial_situation] [nvarchar](max) NULL,
	[Cluster] [nvarchar](50) NULL,
	[burial_length_meters] [decimal](18, 0) NULL,
	[burial_number] [nvarchar](50) NULL,
	[sample_number] [nvarchar](50) NULL,
	[gender_GE] [nvarchar](50) NULL,
	[GE_function_total] [nvarchar](50) NULL,
	[gender_body_col] [nvarchar](50) NULL,
	[osteophytosis] [nvarchar](50) NULL,
	[robust] [nvarchar](50) NULL,
	[artifacts_description] [nvarchar](150) NULL,
	[hair_color] [nvarchar](50) NULL,
	[preservation_index] [nvarchar](50) NULL,
	[burial_preservation] [nvarchar](50) NULL,
	[hair_taken] [nvarchar](50) NULL,
	[soft_tissue_taken] [nvarchar](50) NULL,
	[bone_taken] [nvarchar](50) NULL,
	[tooth_taken] [nvarchar](50) NULL,
	[textile_taken] [nvarchar](50) NULL,
	[description_of_taken] [nvarchar](100) NULL,
	[artifact_found] [nvarchar](50) NULL,
	[estimate_age] [nvarchar](50) NULL,
	[Age_Category] [nvarchar](50) NULL,
	[estimate_living_stature] [nvarchar](50) NULL,
	[tooth_attrition] [nvarchar](50) NULL,
	[tooth_eruption] [nvarchar](50) NULL,
	[pathology_anomalies] [nvarchar](200) NULL,
	[epiphyseal_union] [nvarchar](50) NULL,
	[body_analysis] [nvarchar](50) NULL,
	[year_found] [nvarchar](50) NULL,
	[month_found] [nvarchar](50) NULL,
	[day_found] [nvarchar](50) NULL,
	[head_direction] [nvarchar](50) NULL,
	[Gamous] [nvarchar](50) NULL,
	[field_book] [nvarchar](50) NULL,
	[Field_Book_Page_Number] [nvarchar](50) NULL,
	[Field_Book_Notes] [nvarchar](max) NULL,
	[BYU_has_sample] [nvarchar](50) NULL,
	[osteology_unknown_comment] [nvarchar](100) NULL,
	[Temporal_Mandibular_Joint_Osteoarthritis_TMJ_OA] [nvarchar](100) NULL,
	[Postcrania_at_Magazine] [nvarchar](100) NULL,
	[Linear_Hypoplasia_Enamel] [nvarchar](100) NULL,
	[Postcrania_Trauma] [nvarchar](100) NULL,
	[Area] [nvarchar](50) NULL,
	[Tomb] [nvarchar](100) NULL,
	[Rack] [nvarchar](50) NULL,
	[Shelf] [nvarchar](50) NULL,
	[Osteology_Notes] [nvarchar](200) NULL,
	[Sample_Taken] [nvarchar](50) NULL,
	[SexMethod] [nvarchar](50) NULL,
	[AgeMethod] [nvarchar](50) NULL,
	[Burial_Artifact_Description] [nvarchar](50) NULL,
	[Buried_with_Artifacts] [nvarchar](50) NULL,
 CONSTRAINT [PK_Burial] PRIMARY KEY CLUSTERED 
(
	[Our_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Burial] UNIQUE NONCLUSTERED 
(
	[Our_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BurialSite]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BurialSite](
	[SiteID] [nvarchar](50) NOT NULL,
	[NSLow] [int] NULL,
	[NSHigh] [int] NULL,
	[NS] [nvarchar](50) NULL,
	[EWLow] [nvarchar](50) NULL,
	[EWHigh] [int] NULL,
	[EW] [nvarchar](50) NULL,
	[Burial_Site_ID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BurialSite] PRIMARY KEY CLUSTERED 
(
	[Burial_Site_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[C14Data]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[C14Data](
	[Burial_ID] [nvarchar](50) NULL,
	[Lower_N_S] [int] NULL,
	[Upper_N_s] [int] NULL,
	[N_S] [nvarchar](50) NULL,
	[Lower_East_West] [nvarchar](50) NULL,
	[Upper_East_West] [int] NULL,
	[E_W] [nvarchar](50) NULL,
	[Square] [nvarchar](50) NULL,
	[AREA] [nvarchar](50) NULL,
	[Burial] [nvarchar](50) NULL,
	[Rack] [int] NULL,
	[TUBE] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[Size_ml] [int] NULL,
	[Foci] [nvarchar](50) NULL,
	[C14_Sample_2017] [nvarchar](50) NULL,
	[Location] [nvarchar](100) NULL,
	[Question_s] [nvarchar](150) NULL,
	[column19] [nvarchar](50) NULL,
	[Conventional_14C_age_BP] [int] NULL,
	[_14C_Calendar_Date] [int] NULL,
	[_14C_Calendar_Date_Positive] [int] NULL,
	[AD_BC] [nvarchar](50) NULL,
	[Calibrated_95_Calendar_Date_MAX] [int] NULL,
	[Calibrated_95_Calendar_Date_MAX2] [int] NULL,
	[AD_BC2] [nvarchar](50) NULL,
	[Calibrated_95_Calendar_Date_MIN] [int] NULL,
	[Calibrated_95_Calendar_Date_MIN2] [int] NULL,
	[AD_BC3] [nvarchar](50) NULL,
	[Calibrated_95_Calendar_Date_SPAN] [int] NULL,
	[Calibrated_95_Calendar_Date_AVG] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[Notes] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Head]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Head](
	[OurID] [int] NOT NULL,
	[basilar_suture] [nvarchar](50) NULL,
	[foreman_magnum] [nvarchar](50) NULL,
	[supraorbital_ridges] [nvarchar](50) NULL,
	[orbit_edge] [nvarchar](50) NULL,
	[parietal_bossing] [nvarchar](50) NULL,
	[gonian] [nvarchar](50) NULL,
	[nuchal_crest] [nvarchar](50) NULL,
	[zygomatic_crest] [nvarchar](50) NULL,
	[cranial_suture] [nvarchar](50) NULL,
	[maximum_cranial_length] [nvarchar](50) NULL,
	[maximum_cranial_breadth] [nvarchar](50) NULL,
	[basion_bregma_height] [nvarchar](50) NULL,
	[basion_nasion] [nvarchar](50) NULL,
	[basion_prosthion_length] [nvarchar](50) NULL,
	[bizygomatic_diameter] [nvarchar](50) NULL,
	[nasion_prosthion] [nvarchar](50) NULL,
	[maximum_nasal_breadth] [nvarchar](50) NULL,
	[interorbital_breadth] [nvarchar](50) NULL,
	[Year_on_skull] [nvarchar](50) NULL,
	[Month_on_skull] [nvarchar](50) NULL,
	[Date_on_Skull] [nvarchar](50) NULL,
	[Skull_Trauma] [nvarchar](50) NULL,
	[Age_Skull_2018] [nvarchar](50) NULL,
	[Sex_Skull_2018] [nvarchar](50) NULL,
	[Skull_at_Magazine] [nvarchar](50) NULL,
	[Metopic_Suture] [nvarchar](50) NULL,
	[Button_Osteoma] [nvarchar](50) NULL,
	[Porotic_Hyperostosis] [nvarchar](50) NULL,
	[Porotic_Hyperostosis_LOCATIONS] [nvarchar](50) NULL,
	[Cribra_Orbitala] [nvarchar](50) NULL,
	[TO_BE_CONFIRMED] [nvarchar](50) NULL,
 CONSTRAINT [PK_Head] PRIMARY KEY CLUSTERED 
(
	[OurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hips]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hips](
	[OurID] [int] NOT NULL,
	[ventral_arc] [nvarchar](50) NULL,
	[subpubic_angle] [nvarchar](50) NULL,
	[sciatic_notch] [nvarchar](50) NULL,
	[pubic_bone] [nvarchar](50) NULL,
	[preaur_sulcus] [nvarchar](50) NULL,
	[medial_IP_ramus] [nvarchar](50) NULL,
	[dorsal_pitting] [nvarchar](50) NULL,
	[pubic_symphysis] [nvarchar](50) NULL,
	[iliac_crest] [nvarchar](50) NULL,
 CONSTRAINT [PK_Hips] PRIMARY KEY CLUSTERED 
(
	[OurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemTable]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemTable](
	[ItemID] [nvarchar](50) NOT NULL,
	[BurialID] [int] NULL,
	[BurialNumber] [nvarchar](50) NULL,
	[ItemDescription] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leg]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leg](
	[OurID] [int] NOT NULL,
	[femur_head] [float] NULL,
	[femur_diameter] [nvarchar](50) NULL,
	[femur_length] [nvarchar](50) NULL,
	[tibia_length] [nvarchar](50) NULL,
 CONSTRAINT [PK_Leg] PRIMARY KEY CLUSTERED 
(
	[OurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewHairColor]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewHairColor](
	[HairID] [nvarchar](50) NOT NULL,
	[HairColor] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HairID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Samples]    Script Date: 4/12/2021 8:40:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Samples](
	[Rack] [nvarchar](max) NULL,
	[Bag] [nvarchar](max) NULL,
	[Burial_ID] [nvarchar](max) NOT NULL,
	[Low] [nvarchar](50) NULL,
	[High] [nvarchar](50) NULL,
	[N_S] [nvarchar](50) NULL,
	[Low_2] [nvarchar](50) NULL,
	[High_2] [nvarchar](50) NULL,
	[E_W] [nvarchar](50) NULL,
	[SiteID] [nvarchar](50) NULL,
	[Area] [nvarchar](50) NULL,
	[Burial] [nvarchar](50) NULL,
	[Cluster] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[Previously_Sampled] [bit] NULL,
	[Notes] [nvarchar](max) NULL,
	[Initials] [nvarchar](50) NULL,
	[Notes2] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Burial]  WITH CHECK ADD  CONSTRAINT [FK_Burial_Burial] FOREIGN KEY([Our_ID])
REFERENCES [dbo].[Burial] ([Our_ID])
GO
ALTER TABLE [dbo].[Burial] CHECK CONSTRAINT [FK_Burial_Burial]
GO
USE [master]
GO
ALTER DATABASE [MummyData] SET  READ_WRITE 
GO
