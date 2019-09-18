@interface UGTInitializeOptions : NSObject

@property (nonatomic, strong) NSString *userId;
@property (nonatomic) int askQuestionsTimeout;
@property (nonatomic, strong, readonly) NSString *gdprConsent;
@property (nonatomic) BOOL testMode;

- (UGTInitializeOptions *)init;

- (void)setGdprConsent:(BOOL)given;

@end
