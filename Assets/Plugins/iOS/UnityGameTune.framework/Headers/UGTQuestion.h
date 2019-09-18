#import "UGTAnswer.h"
#import "UGTAnswerType.h"

typedef void (^UGTAnswerHandlerBlock)(UGTAnswer *answer);

@interface UGTQuestion : NSObject

@property (nonatomic, strong, readonly) NSString *name;
@property (nonatomic, strong, readonly) NSMutableArray *alternatives;
@property (nonatomic) UnityGameTuneAnswerType answerType;
@property (copy, readonly) UGTAnswerHandlerBlock handler;

- (NSDictionary *)getJSON;

- (UGTAnswer *)getDefaultAnswer;

- (void)use:(NSString *)chosenAlternative;

@end
