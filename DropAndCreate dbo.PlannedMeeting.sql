USE [SacramentMeetingPlannerContext-b2dec41e-cd7e-4c06-a842-0b9b53d8ffc5]
GO

/****** Object: Table [dbo].[PlannedMeeting] Script Date: 12/19/2017 3:55:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[PlannedMeeting];


GO
CREATE TABLE [dbo].[PlannedMeeting] (
    [ID]            INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    [ClosingSong]   NVARCHAR (MAX) NOT NULL,
    [Conductor]     NVARCHAR (MAX) NOT NULL,
    [EndPrayer]     NVARCHAR (MAX) NOT NULL,
    [MeetingDate]   DATETIME       NOT NULL,
    [OpenningSong]  NVARCHAR (MAX) NOT NULL,
    [OptionalSong]  NVARCHAR (MAX) NULL,
    [SacramentSong] NVARCHAR (MAX) NOT NULL,
    [SpeakerFive]   NVARCHAR (MAX) NULL,
    [SpeakerFour]   NVARCHAR (MAX) NULL,
    [SpeakerOne]    NVARCHAR (MAX) NULL,
    [SpeakerThree]  NVARCHAR (MAX) NULL,
    [SpeakerTwo]    NVARCHAR (MAX) NULL,
    [StartPrayer]   NVARCHAR (MAX) NOT NULL,
    [TopicFive]     NVARCHAR (MAX) NULL,
    [TopicFour]     NVARCHAR (MAX) NULL,
    [TopicOne]      NVARCHAR (MAX) NULL,
    [TopicThree]    NVARCHAR (MAX) NULL,
    [TopicTwo]      NVARCHAR (MAX) NULL
);


