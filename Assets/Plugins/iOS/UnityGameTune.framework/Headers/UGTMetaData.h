#import "UGTJsonStorage.h"

@interface UGTMetaData : UGTJsonStorage

@property (nonatomic, strong) NSString *category;

- (instancetype)initWithCategory:(NSString *)category;
- (BOOL)setRaw:(NSString *)key value:(id)value;
- (void)commit;

@end
