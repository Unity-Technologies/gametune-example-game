typedef NS_ENUM (NSInteger, UnityGameTuneAnswerType) {
    kUnityGameTuneAnswerTypeAlwaysNew,
    kUnityGameTuneAnswerTypeNewUntilUsed
};

@interface UGTAnswerType : NSObject

+ (NSString *)stringFromAnswerType:(UnityGameTuneAnswerType)answerType;

@end
