# Xamarin-Forms-Card-IO-Sample

This app is a demo of how to get Card.IO working in a Xamarin forms app. Base has been done here: https://github.com/EdHubbell/XamFormsCardIO

Sample uses Xamarin.Froms 2.3.3 and targets iOS 10.


Problems: 

1) For some reason on iOS, the form keeps re-appearing after it is closed. I added a check to a bViewAlreadyDisappeared variable, so it doesn't happen now. I don't know the root cause.

2) I can't figure out how to get a reference to the CreditCardEntryPage in Android. If we could figure that out, then I can get rid of the 'MessagingCenter' calls and just be event based. As it stands now, the OnScanSucceeded and OnScanCancelled events are never raised.